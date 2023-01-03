using Microsoft.Data.SqlClient;
using Poc1.Data;
using Poc1.Entidades;
using Poc1.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Poc1.Repositories
{
    public class AtividadeRepositorio : IAtividadeRepositorio
    {
        private readonly Conexao _conexao;

        public AtividadeRepositorio(Conexao conexao)
        {
            _conexao = conexao;
        }

        public List<Atividade> BuscarAtividades()
        {
            var listaAtividades = new List<Atividade>();

            try
            {
                SqlConnection conn = _conexao.Executar();
                string query = "SELECT * FROM Atividades"; 
;
                SqlCommand cmd = new(query, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int Id = int.Parse(dataReader["Id"].ToString());
                    string Nome = dataReader["Nome"].ToString();

                    Atividade Atividade = new Atividade(Id, Nome);
                    listaAtividades.Add(Atividade);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
            return listaAtividades;
        }
    }
}
