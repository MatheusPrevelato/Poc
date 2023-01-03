using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient;
using Poc1.Data;
using Poc1.Entidades;
using Poc1.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Poc1.Repositories
{
    public class ApontamentoRepositorio : IApontamentoRepositorio
    {
        private readonly Conexao _conexao;


        public ApontamentoRepositorio(Conexao conexao)
        {
            _conexao = conexao;
        }

        // Metodo BuscarPorId

        public void Adicionar(Apontamento apontamento)
        {
            SqlConnection conn = _conexao.Executar();

            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandText = "INSERT INTO Apontamentos (Dia, StreamId, AtividadeId, FaseId, Horas, Observacoes)" +
                    "VALUES (@Dia, @StreamId, @AtividadeId, @FaseId, @Horas, @Observacoes)";

                //sqlCommand.Parameters.AddWithValue("@Id", apontamento.Id);
                sqlCommand.Parameters.AddWithValue("@Dia", apontamento.Data);
                sqlCommand.Parameters.AddWithValue("@StreamId", apontamento.StreamId);
                sqlCommand.Parameters.AddWithValue("@AtividadeId", apontamento.AtividadeId);
                sqlCommand.Parameters.AddWithValue("@FaseId", apontamento.FaseId);
                sqlCommand.Parameters.AddWithValue("@Horas", apontamento.Horas);
                sqlCommand.Parameters.AddWithValue("@Observacoes", apontamento.Observacoes);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
            conn.Close();
        }

        public IEnumerable<Apontamento> BuscarPorId(int id)
        {
            SqlConnection conn = _conexao.Executar();
            List<Apontamento> listaApontamentos = new List<Apontamento>();

            try
            {
                string query = "SELECT * FROM Apontamentos INNER JOIN Streams ON Apontamentos.StreamId = Streams.StreamId " +
                    "INNER JOIN Fases ON Apontamentos.FaseId = Fases.FaseId WHERE Apontamentos.Id = " + id;

                SqlCommand cmd = new(query,conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Apontamento apontamento = new()
                    {
                        Id = int.Parse(dataReader["Id"].ToString()),
                        Data = DateTime.Parse(dataReader["Dia"].ToString()),
                        StreamId = int.Parse(dataReader["StreamId"].ToString()),
                        AtividadeId = int.Parse(dataReader["AtividadeId"].ToString()),
                        FaseId = int.Parse(dataReader["FaseId"].ToString()),
                        Horas = int.Parse(dataReader["Horas"].ToString()),
                        Observacoes = dataReader["Observacoes"].ToString()
                    };
                    listaApontamentos.Add(apontamento);
                }
            }
            catch(Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
            conn.Close();
            return listaApontamentos;
        }
    }
}
