using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cibiPreferiti = { "pizza", "pane", "pesce", "pasta", "dolce", "hamburger", "sette" };

            Console.WriteLine($"Ecco i miei {cibiPreferiti.Length} cibi preferiti :");

            foreach (var item in cibiPreferiti)
            {
            Console.WriteLine($"-{item}");    
            Console.WriteLine("");

            }
            Console.WriteLine($"Il mio cibo preferito è: {cibiPreferiti[0]}");
            Console.WriteLine($"In ultimo abbiamo: {cibiPreferiti[cibiPreferiti.Length-1]}");
            Console.WriteLine("--------------------------------------------------");


            Console.WriteLine($"Mentre in mezzo alla classifica abbiamo :");
            Console.WriteLine("");

            if ( cibiPreferiti.Length % 2 == 0 )
            {
                Console.WriteLine($"Probabilmente la classifica è pari e quindi i miei 2 cibi mezzani preferiti sono: {cibiPreferiti[(cibiPreferiti.Length / 2) - 1]} e {cibiPreferiti[(cibiPreferiti.Length / 2)]}");
            }
            else
            {
                Console.WriteLine($"Essendo la classifica dispari, il mio cibo mezzano preferito è: {cibiPreferiti[(cibiPreferiti.Length - 1) / 2]} ");
            }

            Console.WriteLine(Console.ReadLine());


        }

       
    }
}
