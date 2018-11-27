using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_RH.DADOS
{
    class Conexão
    {
        private string connectionString = "Server=localhost;Database=bdcursos;Uid=root;Pwd=16041998";
        private SqlConnection conn;

        public SqlConnection Abrir()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch 
            {
                return null;
            }
        } 

        internal void Fechar()
        {
            conn.Close();
        }

        public bool ExecutarComRetorno(string conexao)
        {
            try
            {
                SqlCommand mySqlCommand = new SqlCommand(conexao, Abrir());
                SqlDataReader SqlDataReader = mySqlCommand.ExecuteReader();
                return SqlDataReader.Read();
            }
            catch 
            {
                return false;
            }
            finally
            {
                Fechar();
            }
        }
        public SqlDataReader ExecutarConsulta(string sql)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, Abrir());
                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch
            {
                return null;
            }
        }

        public SqlDataAdapter ExecutarConsultaTabela(string sql)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, Abrir());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                return adapter;
            }
            catch
            {
                return null;
            }
        }
    }
}
