using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaFisica : Pessoa
    {
        /* Atributos */
        public string? cpf { get; set; }
        public DateTime dataNascimento { get; set; }

        public float salario { get; set; }

        /* Métodos */
        public override float PagarImposto(float salario)
        {
            float imposto = 0;

            if (salario <= 1500)
            {
                imposto = 0;
            }
            else if (salario > 1500 && salario <= 5000)
            {
                imposto = salario * 3 / 100;
            }
            else if (salario > 5000)
            {
                imposto = salario * 5 / 100;
            }

            return imposto;
        }
        public bool ValidarDataNascimento(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNascimento).TotalDays / 365;

            if (anos >= 18)
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