
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PRO.Domain.HelperClasses;
using PRO.Domain.Entities;
namespace PRO.UI.ViewModels
{
    public class FooterViewModel

    {
        public List<CompanyPopularity> PopularCompanies { get; set; }
        public IEnumerable<Review> RecentReviews { get; set; }
        public IEnumerable<GameScore> HighestRatedGames { get; set; }
    }
}