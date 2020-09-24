using System.Collections.Generic;

namespace Exercice3._7
{
    internal interface IArticleDao
    {
        IEnumerable<Article> GetArticleMinMax(int v1, int v2);
    }
}