using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Versenyzők
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            List<Pilóta> pilóták = new List<Pilóta>();
            foreach (var sor in File.ReadAllLines("pilotak.csv").Skip(1)) pilóták.Add(new Pilóta(sor));

            //3.
            Console.WriteLine($"3. feladat: {pilóták.Count}");

            //4.
            Console.WriteLine($"4. feladat: {pilóták.Last().Név}");

            //5.
            Console.WriteLine($"5. feladat: ");
            pilóták.Where(x => x.SzületésiDátum < DateTime.Parse("1901-01-01"))
                .ToList().ForEach(x => Console.WriteLine($"\t{x.Név} ({x.SzületésiDátum.ToString("yyyy. MM. dd.")})"));

            //6.
            Console.WriteLine($"6. feladat: " +
                $"{pilóták.Where(x => x.Rajtszám != null).OrderBy(x => x.Rajtszám).First().Nemzetiség}");

            //7.
            Console.Write($"7. feladat: ");
            pilóták.Where(x => x.Rajtszám != null)
                .GroupBy(x => x.Rajtszám).Where(gr => gr.Count() > 1)
                .ToList().ForEach(x => Console.Write($"{x.Key}, "));
            Console.WriteLine();
        }
    }
}
