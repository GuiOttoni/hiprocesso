using System;
using System.Collections.Generic;
using System.Text;

namespace HiperMercado
{
    public static class Hi
    {
        public static double FormulaMagica(double custo, int validade)
        {
            if(validade > 30)
            {
                return (custo * 1.65);
            }

            if(validade <= 30 && validade >= 15)
            {
                return (custo * 1.45);
            }

            if(validade < 15 && validade > 0)
            {
                return (custo * 1.25);
            }

            // Produto fora de validade
            if(validade <= 0)
            {
                return 0;
            }

            // Indica erro
            return Double.NaN;
        }
    }
}
