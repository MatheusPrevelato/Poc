using Microsoft.Data.SqlClient;
using System;

namespace Poc1.Data
{
    public class Conexao
    {
        public SqlConnection Executar()
        {
            string connString = "Server=DESKTOP-SL53TN7;Database=Poc1_Database;User Id=sa; Password=Bancodedados*";
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
