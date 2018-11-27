using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Sistema_RH.FORMULARIOS;

namespace Sistema_RH.DADOS
{
    //after: class DAOteste
    public class DAORetornaCadastro
    {
        static string CPF;
        //after: public static void
        public void queryDadosCPF(string cpf1)
        {
            CPF = cpf1;

            using (MySqlConnection connectaInBD = DAOConexao.getConnection())
                try
                {

                    string ComandoSQL = "SELECT nome, sexo, endereco, departamento, funcao, estado_civil, email, dt_admissao, dt_nasc FROM funcionarios WHERE cpf = '" + CPF + "'";


                    MessageBox.Show(ComandoSQL);

                    connectaInBD.Open();
                    MySqlCommand inserttDados = new MySqlCommand(ComandoSQL, connectaInBD);

                    MySqlDataReader dr = inserttDados.ExecuteReader();

                    if (dr.HasRows)//preenchimento do form editar com os dados do banco referente ao titular do cpf.
                    {
                        while (dr.Read())
                        {
                            Editar edicao = new Editar();
                            edicao.txtNome2.Text = dr.GetString(0);
                            edicao.txtSexo2.Text = dr.GetString(1);
                            edicao.txtEndereço2.Text = dr.GetString(2);
                            edicao.txtDepartamento2.Text = dr.GetString(3);
                            edicao.txtFunção2.Text = dr.GetString(4);
                            edicao.txtEstadoCivil2.Text = dr.GetString(5);
                            edicao.txtEmail2.Text = dr.GetString(6);
                            edicao.mskDataAdmissão2.Text = dr.GetString(7);
                            edicao.mskDatadeNascimento2.Text = dr.GetString(8);
                            edicao.ShowDialog();
                            //temos que tentar fechar essa conexao, 
                            //pois está acusando conexao aberta quando clicamos no botao atualizar do form editar. 
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nada foi encontrado!");
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                finally
                {
                    connectaInBD.Close();
                }

        }
    }
}
