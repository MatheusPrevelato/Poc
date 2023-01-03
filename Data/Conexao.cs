using Microsoft.Data.SqlClient;
using System;

namespace Poc1.Data
{
    public class Conexao
    {
        public SqlConnection Executar()
        {
            string connString = "Data Source=DESKTOP-11JUK34;Initial Catalog=Poc1_Database;Trusted_Connection=True;";
            try
            {
                SqlConnection conn = new(connString);
                conn.Open();
                return conn;
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
        }
    }
}
