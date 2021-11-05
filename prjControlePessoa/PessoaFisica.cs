using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjControlePessoa
{
    class PessoaFisica: Pessoa
    {
        public string CPF { get; set; }
        public PessoaFisica(string Nome, string Endereco, string CPF) : base(Nome, Endereco)
        {
            this.CPF = CPF;
        }

        public bool Validar()
        {
            if(CPF.Length != 11) return false;
            string[] digitos = CPF.ToCharArray()
            .Select(i => i.ToString()).ToArray();

            return true;
        }
    }
}
