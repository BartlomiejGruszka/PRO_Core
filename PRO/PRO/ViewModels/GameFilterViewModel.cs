using System;
using System.Collections.Generic;
using PRO.Domain.HelperClasses;
using PRO.Entities;
namespace PRO.UI.ViewModels
{
    public class GameFilterViewModel
    {
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<Status> Statuses{ get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public IEnumerable<Platform> Platforms { get; set; }
        public IEnumerable<Company> Companies{ get; set; }
        public IEnumerable<Genre> Genres{ get; set; }
        public PaginatedList<GameScore> GamesScores { get; set; }

    }
}