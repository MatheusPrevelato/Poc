using Microsoft.Data.SqlClient;
using Poc1.Data;
using Poc1.Entidades;
using Poc1.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Poc1.Repositories
{
    public class StreamRepositorio : IStreamRepositorio
    {
        private readonly Conexao _conexao;

        public StreamRepositorio(Conexao conexao)
        {
            _conexao = conexao;
        }

        public List<Stream> BuscarStreams()
        {
            List<Stream> listaStreams = new List<Stream>();
            try
            {
                SqlConnection conn = _conexao.Executar();

                string query = @"SELECT * FROM Streams INNER JOIN Atividades ON Streams.AtividadeId = Atividades.AtividadeId";

                SqlCommand cmd = new(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int Id = int.Parse(dataReader["StreamId"].ToString());
                    string Nome = dataReader["Nome"].ToString();
                    int AtividadeId = int.Parse(dataReader["AtividadeId"].ToString());
                    Stream stream = new(Id, Nome, AtividadeId);
                    listaStreams.Add(stream);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
            return listaStreams;
        }
    }
}
