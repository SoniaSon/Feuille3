using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            IArticleDao dao = new ArticleDao();
            Article article1 = dao.GetArticles("Blanc");
            article1.Afficher();

            Article article2 = dao.GetArticles("Rouge");
            article2.Afficher();

            Article article3 = dao.GetArticles("Bleu");
            article3.Afficher();
        }
    }
}
