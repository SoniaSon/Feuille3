using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3._4
{
    class Article
    {
        public string nomArticle;
        public double prixArticle;
        public int nombredArticle;

        public Article(string nomArticle, double prixArticle, int nombredArticle)
        {
            this.nomArticle = nomArticle;
            this.prixArticle = prixArticle;
            this.nombredArticle = nombredArticle;
        }


        public void Afficher()
        {
            Console.WriteLine("[Affichager l'article]");
            Console.WriteLine("Le nom de l'article : " + nomArticle);
            Console.WriteLine("Le prix de l'article : " + prixArticle);
            Console.WriteLine("Le nombre d'l'Article : " + nombredArticle);
            Console.WriteLine(Environment.NewLine);
        }

        //Ajouter un article
        public void Ajouter()
        {
            nombredArticle++;
            Console.WriteLine("[Ajouter un article]");
            Console.WriteLine("Vous avez ajouté un article, donc il y'a " + nombredArticle + "Article" );
        }


        //Retirer un Article
        public void Retirer()
        {
            if (nombredArticle != 0)
            {
                nombredArticle--;
                Console.WriteLine("[Supprimer un article]");
                Console.WriteLine("Vous avez supprimez un article, il reste " + nombredArticle + " article ");
                Console.WriteLine(Environment.NewLine);
            }

        }

    }
}
