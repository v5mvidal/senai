using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class Pessoa
    {
        /* Atributos */
        public string? nome { get; set; }
        public string? endereco { get; set; }
        public bool enderecoComercial { get; set; }

        /* Método */
        public void PagarImposto() {}
    }
}