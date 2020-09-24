using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var listeEntier = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15 };

            var listeNbDivise5 = listeEntier.Where(valeur => valeur % 5 == 0).ToList();

            Console.WriteLine("Liste des nombres divisible par 5 sont :");
            foreach (int val in listeNbDivise5)
            {
                Console.Write(val + " ");
            }
        }
     }
    
}
