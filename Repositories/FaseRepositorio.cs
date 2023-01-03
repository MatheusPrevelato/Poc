using Microsoft.Data.SqlClient;
using Poc1.Data;
using Poc1.Entidades;
using Poc1.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace Poc1.Repositories
{
    public class FaseRepositorio : IFaseRepositorio
    {
        private readonly Conexao _conexao;

        public FaseRepositorio(Conexao conexao)
        {
            _conexao = conexao;
        }

        public List<Fase> BuscarFases()
        {
            var listaFases = new List<Fase>();

            try
            {
                SqlConnection conn = _conexao.Executar();
                string query = @"SELECT * FROM Fases ORDER BY NOME";

                SqlCommand cmd = new(query, conn);

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = (int)dataReader["Id"];
                    string nome = dataReader["Nome"].ToString();

                    Fase Fase = new(id, nome);

                    listaFases.Add(Fase);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
            return listaFases;
        }
    }
}
