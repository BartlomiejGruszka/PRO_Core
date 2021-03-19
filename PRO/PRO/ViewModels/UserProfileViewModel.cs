using PRO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PRO.Entities;
namespace PRO.ViewModels
{
    public class UserProfileViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }
        public List<UserList> UserLists { get; set; }
        public List<Tuple<GameList, DateTime>> RecentlyUpdatedGames { get; set; }
        public List<GameList> GameLists { get; set; }
        public List<ReviewGametimeViewModel> Reviews { get; set; }
        public List<ListType> ListTypes { get; set; }
        public int? LoggedUserId { get; set; }


    }
}