using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice3._4
{
        internal class ArticleDao : IArticleDao
        {
            public List<Article> ListeArticles { get; }

            public ArticleDao()
            {
                ListeArticles = Util.GetArticles();
            }

            public ArticleDao(List<Article> listeArticles)
            {
                ListeArticles = listeArticles;
            }

            public Article GetArticles(string nomArticle)
            {
                return ListeArticles
                            .FirstOrDefault(art => art.NomArticle.Equals(nomArticle));
            }
    }
}
