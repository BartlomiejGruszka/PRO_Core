using System;
using System.Collections.Generic;
using PRO.Domain.HelperClasses;
using PRO.Domain.Entities;


namespace PRO.UI.ViewModels
{
    public class ArticleDetailsViewModel
    {
        public Article Article { get; set; }
        public IEnumerable<Review>RecentReviews { get; set; }

        public IEnumerable<Game> RecentGames { get; set; }

        public List<GameScore> BestRatedGames { get; set; }

    }
}