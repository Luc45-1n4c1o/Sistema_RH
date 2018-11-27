using System;

namespace Sistema_RH.NEGOCIOS
{
    public sealed class Funcionario
    {
        private string cpf;
        private string rg;
        private string telefone;
        private string nome;
        private string endereco;
        private string sexo;
        private string departamento;
        private string email;
        private string estadocivil;
        private string funcao;
        private string carteiradetrabalho;
        private DateTime admissão;
        private DateTime datanascimento;


        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Email { get => email; set => email = value; }
        public string Estadocivil { get => estadocivil; set => estadocivil = value; }
        public string Funcao { get => funcao; set => funcao = value; }
        public DateTime Admissão { get => admissão; set => admissão = value; }
        public DateTime Datanascimento { get => datanascimento; set => datanascimento = value; }
        public string Rg { get => rg; set => rg = value; }
        public string CarteiraTrabalho { get => carteiradetrabalho; set => carteiradetrabalho = value; }

        public static Funcionario _funcionario = new Funcionario();
    }
}
