﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_RH.Classes
{
    public class FolhadePagamento
    {
        private string razaosocial;
        private string cnpj;
        private string nomefuncionario;
        private decimal salariobase;
        private string departamento;
        private string observacoes;

        public string Razaosocial { get => razaosocial; set => razaosocial = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Nomefuncionario { get => nomefuncionario; set => nomefuncionario = value; }
        public decimal Salariobase { get => salariobase; set => salariobase = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Observacoes { get => observacoes; set => observacoes = value; }

    }
}
