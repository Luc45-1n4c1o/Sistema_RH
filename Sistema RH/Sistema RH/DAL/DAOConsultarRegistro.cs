using MySql.Data.MySqlClient;
using System;

namespace Sistema_RH.DADOS
{
    public class DAOConsultarRegistro
    {
        static bool cpfEncontrado = false;

        public void RealizarConsultaPorCPF(string _cpf)
        {
            using (MySqlConnection connectaInBD = DAOConexao.getConnection())
                try
                {
                    string CPF = _cpf;

                    string ComandoSQL = "SELECT * FROM funcionarios WHERE cpf = '" + CPF + "'";


                    System.Windows.Forms.MessageBox.Show(ComandoSQL);

                    connectaInBD.Open();
                    MySqlCommand inserttDados = new MySqlCommand(ComandoSQL, connectaInBD);
                    MySqlDataReader dr = inserttDados.ExecuteReader();

                    if (dr.HasRows)//se tem linha significa que os dados corresponde e retornei o status como true na funçao situacao mais abaixo
                    {
                        cpfEncontrado = true;
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

        public bool statusDoCpf()
        {
            return cpfEncontrado;
        }
    }
}
