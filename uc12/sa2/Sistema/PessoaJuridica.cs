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
    }
}