using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3._5
{
         public interface IArticleDao
        {
            Article GetArticles(string nomArticle);

            (string, double) GetArticleEtPrix(string nomArticle);

            Tuple<string, double> GetArticleEtPrixTuple(string nomArticle);

        }
}
