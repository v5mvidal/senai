using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaJuridica : Pessoa
    {
        /* Atributos */
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }

        /* Métodos */
        public override void PagarImposto(float rendimento) { }

        public bool ValidarCnpj(string cnpj)
        {
            if (cnpj.Length >= 14 && (cnpj.Substring(cnpj.Length - 4)) == "0001")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}