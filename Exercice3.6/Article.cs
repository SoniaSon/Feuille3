using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3._6
{
        class Article
        {
            public string nomArticle;
            public double prixArticle;
            public int quantiteArticle;

            public Article(string nomArticle, double prixArticle, int quantiteArticle)
            {
                this.nomArticle = nomArticle;
                this.prixArticle = prixArticle;
                this.quantiteArticle = quantiteArticle;
            }


            public void Afficher()
            {
                Console.WriteLine("[Affichager l'article]");
                Console.WriteLine("Le nom de l'article : " + nomArticle);
                Console.WriteLine("Le prix de l'article : " + prixArticle);
                Console.WriteLine("Le nombre d'l'Article : " + quantiteArticle);
                Console.WriteLine(Environment.NewLine);
            }

            //Ajouter un article
            public void Ajouter()
            {
                quantiteArticle++;
                Console.WriteLine("[Ajouter un article]");
                Console.WriteLine("Vous avez ajouté un article, donc il y'a " + quantiteArticle + "Article");
            }


            //Retirer un Article
            public void Retirer()
            {
                if (quantiteArticle != 0)
                {
                    quantiteArticle--;
                    Console.WriteLine("[Supprimer un article]");
                    Console.WriteLine("Vous avez supprimez un article, il reste " + quantiteArticle + " article ");
                    Console.WriteLine(Environment.NewLine);
                }

            }
        }

}