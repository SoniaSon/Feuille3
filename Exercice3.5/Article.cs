using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3._5
{
    public class Article
    {
        public string NomArticle;
        public double PrixArticle;
        public int QuantiteArticle;

        public Article(string nomArticle, double prixArticle, int quantiteArticle)
        {
            NomArticle = nomArticle;
            PrixArticle = prixArticle;
            QuantiteArticle = quantiteArticle;
        }
        public Article(string nomArticle)
        {
            NomArticle = nomArticle;
        }


        public void Afficher()
        {
            Console.WriteLine("Le nom de l'article : " + NomArticle);
            Console.WriteLine("Le prix de l'article : " + PrixArticle);
            Console.WriteLine("Le nombre d'l'Article : " + QuantiteArticle);
            Console.WriteLine(Environment.NewLine);
        }

        //Ajouter un article
        public void Ajouter()
        {
            QuantiteArticle++;
            Console.WriteLine("[Ajouter un article]");
            Console.WriteLine("Vous avez ajouté un article, donc il y'a " + QuantiteArticle + "Article");
        }


        //Retirer un Article
        public void Retirer()
        {
            if (QuantiteArticle != 0)
            {
                QuantiteArticle--;
                Console.WriteLine("[Supprimer un article]");
                Console.WriteLine("Vous avez supprimez un article, il reste " + QuantiteArticle + " article ");
                Console.WriteLine(Environment.NewLine);
            }

        }
    }
}