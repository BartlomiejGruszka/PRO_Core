
using System.Collections.Generic;
using PRO.Entities;
namespace PRO.UI.ViewModels
{
    public class GameDetailsViewModel
    {
        public GameAndGameListFormViewModel GameGameList { get; set; }
        public List<Game> RecommendedGames { get; set; }
        public IEnumerable<ReviewPlaytimeViewModel> ReviewGametimes { get; set; }
        public IEnumerable<Article> RelevantArticles { get; set; }

    }
}