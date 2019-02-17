using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessoSeletivo.Ex03
{
    public class Rua
    {
        public Rua()
        {

        }

        public Rua(string _cep, string _nome)
        {
            this.CEP = _cep;
            this.Nome = _nome;
        }

        public string CEP { get; set; }
        public string Nome { get; set; }
    }
}
