using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessoSeletivo.Ex03
{
    public class Casa
    {
        public Casa()
        {

        }

        public Casa(Rua _rua, int _numero, int _totalEleitores)
        {
            this.Rua = _rua;
            this.Numero = _numero;
            this.TotalEleitores = _totalEleitores;
        }

        public Rua Rua { get; set; }
        public int Numero { get; set; }
        public int TotalEleitores { get; set; }
    }
}
