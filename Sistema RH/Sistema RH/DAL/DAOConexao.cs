using MySql.Data.MySqlClient;

namespace Sistema_RH.DADOS
{
    // selando a classe DAOConexao para não criar instâncias da classe.
   sealed class DAOConexao
   {
        // propriedade de conexão
        static private MySqlConnection conn = null;

        private DAOConexao() // Construtor
        { }

        // método que retorna uma conexão com a base de dados, usando o Patterns ""
        static public MySqlConnection getConnection()
        {
            if (conn == null)
            {
                conn = new MySqlConnection("Server=localhost;Database=sistema_rh;Uid=lucas;Pwd=MuchaLucha");
            }

            return conn;
        }




   }
}
