
using System;
using System.Collections.Generic;
using PRO.Domain.HelperClasses;
using PRO.Entities;
namespace PRO.UI.ViewModels
{
    public class GameDetailsViewModel
    {
        public GameAndGameListFormViewModel GameGameList { get; set; }
        public List<Game> RecommendedGames { get; set; }
        public PaginatedList<ReviewPlaytime> ReviewPlaytimes { get; set; }
        public IEnumerable<Article> RelevantArticles { get; set; }

    }
}