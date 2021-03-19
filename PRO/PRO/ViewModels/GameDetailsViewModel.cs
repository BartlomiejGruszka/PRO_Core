﻿using PRO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PRO.Entities;
namespace PRO.ViewModels
{
    public class GameDetailsViewModel
    {
        public GameAndGameListFormViewModel GameGameList { get; set; }
        public List<Game> RecommendedGames { get; set; }
        public IEnumerable<ReviewGametimeViewModel> ReviewGametimes { get; set; }
        public IEnumerable<Article> RelevantArticles { get; set; }

    }
}