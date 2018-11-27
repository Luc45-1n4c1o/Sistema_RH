using MySql.Data.MySqlClient;
using System;


namespace Sistema_RH.DADOS
{
    class DAOEditarRegistro
    {
        public void EditarDadosFuncionario(string nome, string sexo, string endereco, string depart, string funcao, string estCivil, DateTime admissao, DateTime dtNasc, string cpf, string phone, string email, string rg, string cartTrab)
        {
            using (MySqlConnection connectaInBD2 = DAOConexao.getConnection())
                try
                {
                    string Nome = nome;
                    string Sexo = sexo;
                    string Endereco = endereco;
                    string Departamento = depart;
                    string Funcao = funcao;
                    string EstadoCivil = estCivil;
                    DateTime Admissao = admissao;
                    DateTime DtNascimento = dtNasc;
                    string CPF = cpf;
                    string Telefone = phone;
                    string Email = email;
                    string RG = rg;
                    string CarteiraDeTrabalho = cartTrab;

                    string ComandoSQL = "UPDATE funcionarios SET nome = 'Andreia', sexo = 'F', endereco = 'Sao Paulo', " +
                        "departamento = 'Mídias Digitais', funcao = 'CopyWriter', estado_civil = 'Solteira', email = 'andreia@gmail.com', dt_admissao = '', dt_nasc = '', " +
                        "cpf = '137.660.123-55', rg = '3.777.999-ES', carteira_trab = '90850', telefone = '(28)99999-9999' WHERE cpf = '137.660.321-55'";

                    /*
                     kkkkkk
                    string ComandoSQL = "INSERT INTO folhadepagamento (razao_social, cnpj, nome_do_funcionario, salario_base, departamento, observacoes)" +
                        " VALUES ('" + RazaoSocial + "','" + CNPJ + "','" + NomeFuncionario + "','" + SalarioBase + "','" + Departamento + "', '" + Observacoes + "')";
                    */

                    System.Windows.Forms.MessageBox.Show(ComandoSQL);
                    
                    connectaInBD2.Open();
                    MySqlCommand inserttDados = new MySqlCommand(ComandoSQL, connectaInBD2);

                    /*
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
                    */

                    inserttDados.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                finally
                {
                    connectaInBD2.Close();
                }
        }
    }
}
