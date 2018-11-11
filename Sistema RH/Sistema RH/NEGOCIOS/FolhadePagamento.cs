using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_RH.Classes
{
    class FolhadePagamento
    {
        private string razaosocial;
        private int cnpj;
        private string nomefuncionario;
        private double salariobase;
        private string departamento;
        private string observacoes;

        public string Razaosocial { get => razaosocial; set => razaosocial = value; }
        public int Cnpj { get => cnpj; set => cnpj = value; }
        public string Nomefuncionario { get => nomefuncionario; set => nomefuncionario = value; }
        public double Salariobase { get => salariobase; set => salariobase = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Observacoes { get => observacoes; set => observacoes = value; }

        
    }
}
