using System;

namespace Exercice3._6
{
    internal interface IArticleDao
    {
        Tuple<string, double> GetArticleEtPrixTuple(string v);
    }
}