﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice3._7
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

        public (string, double) GetArticleEtPrix(string nomArticle)
        {
            var res = ListeArticles.Where(art => art.NomArticle.Equals(nomArticle)).Select(art => new { art.NomArticle, art.PrixArticle }).FirstOrDefault();
            if (res != null)
                return (res.NomArticle, res.PrixArticle);
            return ("Article non trouvé", 0);
        }
        public Tuple<string, double> GetArticleEtPrixTuple(string nomArticle)
        {
            var res = ListeArticles
                .Where(art => art.NomArticle.Equals(nomArticle))
                .Select(art => new Tuple<string, double>(art.NomArticle, art.PrixArticle))
                .FirstOrDefault();
            return res;
        }
        public IEnumerable<Article> GetArticleMinMax(int min, int max)
        {
            var res = from unArticle in ListeArticles
                      where unArticle.QuantiteArticle >= min && unArticle.QuantiteArticle <= max
                      select unArticle;
            return res;
        }
    }
}
