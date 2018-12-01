using System;
using MySql.Data.MySqlClient;

namespace Sistema_RH.DADOS
{
    public class DAOFolhadePagamento
    {
        public void CadastrarPayment(string rsocial, string cnpj, string nomefunc, string sbase, string depart, string obs)
        {
            using (MySqlConnection connectaInBD = DAOConexao.getConnection())
                try
                {
                    string RazaoSocial = rsocial;
                    string CNPJ = cnpj;
                    string NomeFuncionario = nomefunc;
                    string SalarioBase = sbase;
                    string Departamento = depart;
                    string Observacoes = obs;
                    
                    string ComandoSQL = "INSERT INTO folhadepagamento (razao_social, cnpj, nome_do_funcionario, salario_base, departamento, observacoes)" +
                        " VALUES (@razao_social, @cnpj, @nome_do_funcionario, @salario_base, @departamento, @observacoes)";

                    connectaInBD.Open();
                    MySqlCommand inserttDados = new MySqlCommand(ComandoSQL, connectaInBD);

                    inserttDados.Parameters.Add("@razao_social", MySqlDbType.VarChar, 100);
                    inserttDados.Parameters.Add("@cnpj", MySqlDbType.VarChar, 30);
                    inserttDados.Parameters.Add("@nome_do_funcionario", MySqlDbType.VarChar, 100);
                    inserttDados.Parameters.Add("@salario_base", MySqlDbType.VarChar, 9);
                    inserttDados.Parameters.Add("@departamento", MySqlDbType.VarChar, 50);
                    inserttDados.Parameters.Add("@observacoes", MySqlDbType.VarChar, 500);

                    inserttDados.Parameters["@razao_social"].Value = RazaoSocial;
                    inserttDados.Parameters["@cnpj"].Value = CNPJ;
                    inserttDados.Parameters["@nome_do_funcionario"].Value = NomeFuncionario;
                    inserttDados.Parameters["@salario_base"].Value = SalarioBase;
                    inserttDados.Parameters["@departamento"].Value = Departamento;
                    inserttDados.Parameters["@observacoes"].Value = Observacoes;


                    inserttDados.ExecuteNonQuery();
                    
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

    }
}
