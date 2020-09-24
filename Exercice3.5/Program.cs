using System;

namespace Exercice3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            IArticleDao dao = new ArticleDao();
            (string nomAritcle, double prixArticle) = dao.GetArticleEtPrix("Blanc");
            Console.WriteLine("Nom de l'article: {nomAritcle}, Prix de l'article : {prixArticle}");
        }
    }
}
