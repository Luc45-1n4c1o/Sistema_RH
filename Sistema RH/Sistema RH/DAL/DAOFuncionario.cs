using MySql.Data.MySqlClient;
using System;

namespace Sistema_RH.DADOS
{
    class DAOFuncionario
    {
        
        public static void InsertBD()
        {
            using (MySqlConnection connecta = DAOConexao.getConnection())
            try
            {
                string Nome = NEGOCIOS.Funcionario._funcionario.Nome;
                string Sexo = NEGOCIOS.Funcionario._funcionario.Sexo;
                string Depto = NEGOCIOS.Funcionario._funcionario.Departamento;
                string Funcao = NEGOCIOS.Funcionario._funcionario.Funcao;
                string EstCivil = NEGOCIOS.Funcionario._funcionario.Estadocivil;
                DateTime Admissao = NEGOCIOS.Funcionario._funcionario.Admissão;
                DateTime Dt_Nasc = NEGOCIOS.Funcionario._funcionario.Datanascimento;
                string CPF = NEGOCIOS.Funcionario._funcionario.Cpf;
                string Tel = NEGOCIOS.Funcionario._funcionario.Telefone;
                string Email = NEGOCIOS.Funcionario._funcionario.Email;
                string RG = NEGOCIOS.Funcionario._funcionario.Rg;
                string CarteiraTrab = NEGOCIOS.Funcionario._funcionario.CarteiraTrabalho;
                string Endereco = NEGOCIOS.Funcionario._funcionario.Endereco;
                
                //string que encapsula os comandos SQL a serem executados na base de dados
                string InsComand = "INSERT INTO funcionarios (nome , sexo, endereco, departamento, funcao, estado_civil, email, dt_admissao, dt_nasc, cpf, rg, carteira_trab, telefone)" +
                        " VALUES ('" + Nome + "','" + Sexo + "','" + Endereco + "','" + Depto + "','" + Funcao + "', '" + EstCivil + "', '" + Email + 
                        "', '" + Admissao.ToString("yyyy-MM-dd") + "','" + Dt_Nasc.ToString("yyyy-MM-dd") + "','" + CPF + "','" + RG + "','" + CarteiraTrab + "','" + Tel + "')";

                connecta.Open();
                MySqlCommand insertt = new MySqlCommand(InsComand, connecta);
                insertt.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
               connecta.Close();
            }
        }
               

    }
}
