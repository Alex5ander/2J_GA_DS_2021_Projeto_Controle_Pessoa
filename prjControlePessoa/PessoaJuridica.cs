using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjControlePessoa
{
    class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
        public PessoaJuridica(string Nome, string Endereco, string CNPJ) : base (Nome, Endereco)
        {
            this.CNPJ = CNPJ;
        }

        public bool Validar()
        {
            return true;
        }
    }
}
