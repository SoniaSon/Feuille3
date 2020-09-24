using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice3._2
{
    class Program
    {

        private static void Main(string[] args)
        {
            var listeAnnee = new List<int> { 2000, 2001, 2004, 2010, 2012, 2015, 2020 };

            var annee =
                from uneAnnee in listeAnnee
                where DateTime.IsLeapYear(uneAnnee)
                select uneAnnee;

            var nbrValeurs = annee.Count();
                Console.WriteLine("La liste des années bissextiles");
                var listeAnneesBissextiles = annee.ToList();
                foreach (var anneesBissextile in listeAnneesBissextiles) Console.Write(anneesBissextile + " ");
 
        }
    }
}
