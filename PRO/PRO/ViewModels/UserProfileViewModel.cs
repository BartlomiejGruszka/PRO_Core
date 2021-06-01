using System;
using System.Collections.Generic;
using PRO.Domain.HelperClasses;
using PRO.Entities;

namespace PRO.UI.ViewModels
{
    public class UserProfileViewModel
    {
        public List<UserList> UserLists { get; set; }
        public List<Tuple<GameList, DateTime>> RecentlyUpdatedGames { get; set; }
        public List<GameList> GameLists { get; set; }
        public PaginatedList<ReviewPlaytime> ReviewsPlaytimes { get; set; }
        public List<ListType> ListTypes { get; set; }
        public int? LoggedUserId { get; set; }
        public EditUserViewModel EditUser { get; set; }
        public ChangePasswordViewModel ChangePassword { get; set; }

    }
}