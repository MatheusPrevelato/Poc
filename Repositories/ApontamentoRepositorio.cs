using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Poc1.Data;
using Poc1.Models;
using System;

namespace Poc1.Repositories
{
    public class ApontamentoRepositorio : IApontamentoRepositorio
    {
        private readonly Conexao _conexao;


        public ApontamentoRepositorio(Conexao conexao)
        {
            _conexao = conexao;
        }

        public void Adicionar(ApontamentoModel apontamento)
        {
            SqlConnection conn = _conexao.Executar();

            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandText = "INSERT INTO Apontamentos (Dia, Stream, Atividade, Fase, Horas, Observacoes)" +
                    "VALUES (@Dia, @Stream, @Atividade, @Fase, @Horas, @Observacoes)";

                //sqlCommand.Parameters.AddWithValue("@Id", apontamento.Id);
                sqlCommand.Parameters.AddWithValue("@Dia", apontamento.Dia);
                sqlCommand.Parameters.AddWithValue("@Stream", apontamento.Stream);
                sqlCommand.Parameters.AddWithValue("@Atividade", apontamento.Atividade);
                sqlCommand.Parameters.AddWithValue("@Fase", apontamento.Fase);
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
