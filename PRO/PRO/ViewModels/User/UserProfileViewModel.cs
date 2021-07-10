using System;
using System.Collections.Generic;
using PRO.Domain.HelperClasses;
using PRO.Entities;

namespace PRO.UI.ViewModels
{
    public class UserProfileViewModel
    {
        public List<Tuple<GameList, DateTime>> RecentlyUpdatedGames { get; set; }
        public PaginatedList<GameList> GameLists { get; set; }
        public PaginatedList<ReviewPlaytime> ReviewsPlaytimes { get; set; }
        public List<ListType> ListTypes { get; set; }
        public ApplicationUser AppUser { get; set; }

    }
}