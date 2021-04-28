using System;
using System.Collections.Generic;
using PRO.Entities;


namespace PRO.UI.ViewModels
{
    public class ArticleDetailsViewModel
    {
        public Article Article { get; set; }
        public IEnumerable<Review>RecentReviews { get; set; }

        public IEnumerable<Game> RecentGames { get; set; }

        public List<Tuple<Game, double?>> BestRatedGames { get; set; }

    }
}