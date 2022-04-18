using System;
using System.Collections.Generic;
using PRO.Domain.HelperClasses;
using PRO.Domain.Entities;
namespace PRO.UI.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Article> RecentArticles { get; set; }
        public IEnumerable<Game> RecentGames{ get; set; }
        public IEnumerable<Review>RecentReviews { get; set; }
        public IEnumerable<Game> ComingGames { get; set; }
        public List<GamePopularity> MostPopularGames { get; set; }
        public List<GameScore> BestRatedGames { get; set; }
    }
}