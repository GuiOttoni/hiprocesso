using ProcessoSeletivo.Ex02;
using ProcessoSeletivo.Ex03;
using System;

namespace ProcessoSeletivo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 02
            ExercicioDois exDois = new ExercicioDois();
            exDois.Executa();

            Console.WriteLine("==========================================================");

            //Exercicio 03
            ExercicioTres exTres = new ExercicioTres();
            exTres.Executa();

            Console.Read();
        }
    }
}
