using System;

namespace Exercice3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            IArticleDao dao = new ArticleDao();
            Tuple<string, double> res = dao.GetArticleEtPrixTuple("Blanc");
            Console.WriteLine($"Nom de l'article: {res.Item1}, Prix de l'article : {res.Item2}");
        }
    }
}
