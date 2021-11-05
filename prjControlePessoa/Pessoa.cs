using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjControlePessoa
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Pessoa(string Nome, string Endereco)
        {
            this.Nome = Nome;
            this.Endereco = Endereco;
        }
    }
}
