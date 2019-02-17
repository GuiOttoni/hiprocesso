using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProcessoSeletivo.Ex03
{
    public class ExercicioTres
    {
        private List<Casa> casas { get; set; }

        public ExercicioTres()
        {
            casas = new List<Casa>();
            Rua ruaA = new Rua("00001-111", "Rua A");
            Rua ruaB = new Rua("00002-222", "Rua B");
            Rua ruaC = new Rua("00003-333", "Rua C");
            Rua ruaX = new Rua("00004-444", "Rua X");
            Rua ruaY = new Rua("00005-555", "Rua Y");
            Rua ruaZ = new Rua("00006-666", "Rua Z");

            casas.Add(new Casa(ruaA, 102, 1));  //
            casas.Add(new Casa(ruaA, 104, 2));  // 6
            casas.Add(new Casa(ruaA, 106, 3));  //
                                                //
            casas.Add(new Casa(ruaB, 102, 4));  //
            casas.Add(new Casa(ruaB, 104, 3));  // 8
            casas.Add(new Casa(ruaB, 106, 1));  //
                                                //
            casas.Add(new Casa(ruaC, 102, 6));  //
            casas.Add(new Casa(ruaC, 104, 2));  // 12
            casas.Add(new Casa(ruaC, 106, 4));  //
                                                //
            casas.Add(new Casa(ruaX, 102, 2));  //
            casas.Add(new Casa(ruaX, 104, 1));  // 7
            casas.Add(new Casa(ruaX, 106, 4));  //
                                                //
            casas.Add(new Casa(ruaY, 102, 4));  //
            casas.Add(new Casa(ruaY, 104, 1));  // 9
            casas.Add(new Casa(ruaY, 106, 4));  //
                                                //
            casas.Add(new Casa(ruaZ, 102, 5));  //
            casas.Add(new Casa(ruaZ, 104, 4));  // 11
            casas.Add(new Casa(ruaZ, 106, 2));  //
        }

        public void Executa()
        {
            List<Rua> ruasOrdenadas = OrdenaRua(this.casas);
            Console.WriteLine("Ruas ordernadas do maior pro menor");
            ruasOrdenadas.ForEach(p => {
                Console.WriteLine(p.Nome);
            });
        }

        private List<Rua> OrdenaRua(List<Casa> casas)
        {
            var a = casas.GroupBy(x => x.Rua)
                         .ToList()
                         .OrderByDescending(y => y.Sum(p => p.TotalEleitores))
                         .Select(z=> z.Key)
                         .ToList();
            return a;
        }
    }
}
