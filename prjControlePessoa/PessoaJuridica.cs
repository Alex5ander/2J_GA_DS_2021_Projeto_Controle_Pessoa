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

        public int calcular(int peso, int length, string[] digitos)
        {
            int soma = 0;
            for (int i = 0; i < length; i++)
            {
                if (peso < 2) peso = 9;
                soma += peso * Int16.Parse(digitos[i]);
                peso--;
            }
            return soma;
        }

        public bool Validar()
        {
            if (CNPJ.Length != 14) return false;
            string[] digitos = CNPJ.ToCharArray()
            .Select(i => i.ToString()).ToArray();

            int peso = 5;
            int soma = calcular(peso, 12, digitos);
            int resto = soma % 11;
            int div1 = resto < 2 ? 0 : 11 - resto;

            if (div1.ToString() != digitos[12]) return false;

            peso = 6;
            soma = calcular(peso, 13, digitos);
            resto = soma % 11;
            int div2 = resto < 2 ? 0 : 11 - resto;

            if (div2.ToString() != digitos[13]) return false;

            return true;
        }
    }
}
