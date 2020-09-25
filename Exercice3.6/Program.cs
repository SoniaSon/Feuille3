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

            Tuple<string, double> res1 = dao.GetArticleEtPrixTuple("Rouge");
            Console.WriteLine($"Nom de l'article: {res1.Item1}, Prix de l'article : {res1.Item2}");

            Tuple<string, double> res2 = dao.GetArticleEtPrixTuple("Bleu");
            Console.WriteLine($"Nom de l'article: {res2.Item1}, Prix de l'article : {res2.Item2}");
        }
    }
}
