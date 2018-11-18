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
                        " VALUES ('" + RazaoSocial + "','" + CNPJ + "','" + NomeFuncionario + "','" + SalarioBase + "','" + Departamento + "', '" + Observacoes + "')";


                    System.Windows.Forms.MessageBox.Show(ComandoSQL);

                    connectaInBD.Open();
                    MySqlCommand inserttDados = new MySqlCommand(ComandoSQL, connectaInBD);
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
