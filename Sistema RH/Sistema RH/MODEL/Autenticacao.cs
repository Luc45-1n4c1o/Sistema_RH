using MySql.Data.MySqlClient;
using Sistema_RH.DADOS;
using System;


namespace Sistema_RH.NEGOCIOS
{
    public static class Autenticacao
    {
        static string Usuario;
        static string Senha;
        static bool status = false;

        public static bool Status { get => status; set => status = value; }

        public static void login(string usuario1, string senha1)
        {
            Usuario = usuario1;
            Senha = senha1;

            using (MySqlConnection connectaInBD = DAOConexao.getConnection())
                try
                {

                    string ComandoSQL = "SELECT * FROM autentificacao WHERE usuario = '" + Usuario + "' and senha = '" + Senha + "'";


                    System.Windows.Forms.MessageBox.Show(ComandoSQL);

                    connectaInBD.Open();
                    MySqlCommand inserttDados = new MySqlCommand(ComandoSQL, connectaInBD);
                    MySqlDataReader dr = inserttDados.ExecuteReader();

                    if (dr.HasRows)//se tem linha significa que os dados corresponde e retornei o status como true na funçao situacao mais abaixo
                    {
                        Status = true;
                    }
                    
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                finally
                {
                    connectaInBD.Close();
                }
            
        }
        public static bool situacao()
        {
            return status;
        }
    }
}
