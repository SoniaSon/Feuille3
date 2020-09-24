using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3._4
{
    public interface IArticleDao
    {
        Article GetArticles(string nomArticle);
    }
}