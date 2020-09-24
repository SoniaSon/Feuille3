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
            Article article1 = dao.GetArticles();
            article1.Afficher();

            Article article2 = dao.GetArticles();
            article2.Afficher();

            Article article3 = dao.GetArticles();
            article3.Afficher();
        }
    }
}
