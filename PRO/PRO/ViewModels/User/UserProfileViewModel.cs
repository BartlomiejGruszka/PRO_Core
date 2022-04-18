using System;
using System.Collections.Generic;
using PRO.Domain.HelperClasses;
using PRO.Domain.Entities;

namespace PRO.UI.ViewModels
{
    public class UserProfileViewModel
    {
        public List<GameListDate> RecentlyUpdatedGames { get; set; }
        public List<GameList> GameLists { get; set; }
        public PaginatedList<ReviewPlaytime> ReviewsPlaytimes { get; set; }
        public List<ListType> ListTypes { get; set; }
        public ApplicationUser AppUser { get; set; }

    }
}