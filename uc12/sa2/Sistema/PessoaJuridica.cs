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
        public override float PagarImposto(float rendimento) {
            float imposto = 0;

            if (rendimento <= 5000)
            {
                imposto = rendimento * 6 / 100;
            }
            else if (rendimento > 5000 && rendimento <= 10000)
            {
                imposto = rendimento * 8 / 100;
            }
            else if (rendimento > 10000)
            {
                imposto = rendimento * 10 / 100;
            }

            return imposto;
        }

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