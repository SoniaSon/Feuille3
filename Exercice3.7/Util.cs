using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3._7
{
    static class Util
    {
        public static List<Article> GetArticles()
        {
            List<Article> Art = new List<Article>()
            {
                new Article("Blanc", 50, 5),
                new Article("Rouge", 100, 10),
                new Article("Bleu", 70, 8),
            };
            return Art;
        }
    }
}
