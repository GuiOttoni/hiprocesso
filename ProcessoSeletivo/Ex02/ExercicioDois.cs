using HiperMercado;
using System;

namespace ProcessoSeletivo.Ex02
{
    public class ExercicioDois
    {
        public void Executa()
        {
            // variavel custo  ́e um double definido previamente
            // variavel validade  e um int definido previamente
            Console.WriteLine("Produto 1, custo 2.00, validade 30 dias");
            Console.WriteLine($"Preço: {HiperMercado.Hi.FormulaMagica(2.00, 30)}");

            Console.WriteLine("Produto 1, custo 15.00, validade 14 dias");
            Console.WriteLine($"Preço: {HiperMercado.Hi.FormulaMagica(15.00, 14)}");

            Console.WriteLine("Produto 1, custo 35.00, validade 22 dias");
            Console.WriteLine($"Preço: {HiperMercado.Hi.FormulaMagica(35.00, 22)}");

        }

        
    }
}
