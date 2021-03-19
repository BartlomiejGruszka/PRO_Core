﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PRO.Models;
using PRO.Entities;
namespace PRO.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Article> RecentArticles { get; set; }
        public IEnumerable<Game> RecentGames{ get; set; }
        public IEnumerable<Review>RecentReviews { get; set; }
        public IEnumerable<Game> ComingGames { get; set; }
        public List<Tuple<Game, int?>> MostPopularGames { get; set; }
        public List<Tuple<Game, double?>> BestRatedGames { get; set; }
    }
}