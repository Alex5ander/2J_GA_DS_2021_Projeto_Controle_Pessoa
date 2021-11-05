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

            int peso = 10;
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += peso * Int16.Parse(digitos[i]); 
                peso --;
            }

            int resto = soma % 11;
            int div1 = resto < 2 ? 0 : 11 - resto;

            if(div1.ToString() != digitos[9]) 
            {
                return false;
            }

            peso = 11;
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += peso * Int16.Parse(digitos[i]);
                peso--;
            }

            resto = soma % 11;
            int div2 = resto < 2 ? 0 : 11 - resto;

            if(div2.ToString() != digitos[10]) {
                return false;
            }

            Console.WriteLine(div1);
            return true;
        }
    }
}
