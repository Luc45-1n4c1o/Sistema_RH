using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sistema_RH.Classes;
using Sistema_RH.FORMULARIOS;
using Sistema_RH.NEGOCIOS;

namespace Sistema_RH.DADOS
{
    public class DAOFolhadePagamento
    {
        public void CadastrarPayment(string rsocial, string cnpj, string nomefunc, decimal sbase, string depart, string obs)
        {
            using (MySqlConnection connectaInBD = DAOConexao.getConnection())
                try
                {
                    string RazaoSocial = rsocial;
                    string CNPJ = cnpj;
                    string NomeFuncionario = nomefunc;
                    decimal SalarioBase = sbase;
                    string Departamento = depart;
                    string Observacoes = obs;
                    
                    string ComandoSQL = "INSERT INTO folhadepagamento (razao_social, cnpj, nome_do_funcionario, salario_base, departamento, observacoes)" +
                        " VALUES (@razao_social, @cnpj, @nome_do_funcionario, @salario_base, @departamento, @observacoes)";

                    /*
                     
                    string ComandoSQL = "INSERT INTO folhadepagamento (razao_social, cnpj, nome_do_funcionario, salario_base, departamento, observacoes)" +
                        " VALUES ('" + RazaoSocial + "','" + CNPJ + "','" + NomeFuncionario + "','" + SalarioBase + "','" + Departamento + "', '" + Observacoes + "')";

                    command.Parameters.Add("@id", MySqlDbType.VarChar,20);
                    command.Parameters.Add("@name", MySqlDbType.VarChar, 200);
                    command.Parameters.Add("@desc", MySqlDbType.Text);
                    command.Parameters.Add("@img", MySqlDbType.Blob);

                    command.Parameters["@id"].Value = textBoxID.Text;
                    command.Parameters["@name"].Value = textBoxNAME.Text;
                    command.Parameters["@desc"].Value = textBoxDESC.Text;
                    command.Parameters["@img"].Value = img;
                     
                     */

                    System.Windows.Forms.MessageBox.Show(ComandoSQL);

                    connectaInBD.Open();
                    MySqlCommand inserttDados = new MySqlCommand(ComandoSQL, connectaInBD);

                    inserttDados.Parameters.Add("@razao_social", MySqlDbType.VarChar, 100);
                    inserttDados.Parameters.Add("@cnpj", MySqlDbType.VarChar, 30);
                    inserttDados.Parameters.Add("@nome_do_funcionario", MySqlDbType.VarChar, 100);
                    inserttDados.Parameters.Add("@salario_base", MySqlDbType.Decimal, 12);
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
