using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient;
using Poc1.Data;
using Poc1.Models;
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
        
        public void Adicionar(ApontamentoModel apontamento)
        {
            SqlConnection conn = _conexao.Executar();

            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandText = "INSERT INTO Apontamentos (Dia, StreamId, AtividadeId, FaseId, Horas, Observacoes)" +
                    "VALUES (@Dia, @StreamId, @AtividadeId, @FaseId, @Horas, @Observacoes)";

                //sqlCommand.Parameters.AddWithValue("@Id", apontamento.Id);
                sqlCommand.Parameters.AddWithValue("@Dia", apontamento.Dia);
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
    }
}
