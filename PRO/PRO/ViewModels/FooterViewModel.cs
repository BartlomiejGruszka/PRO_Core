
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PRO.Entities;
namespace PRO.UI.ViewModels
{
    public class FooterViewModel

    {
        public List<Tuple<Company, int>> PopularCompanies { get; set; }
        public IEnumerable<Review> RecentReviews { get; set; }
        public IEnumerable<Tuple<Game, double?>> HighestRatedGames { get; set; }
    }
}