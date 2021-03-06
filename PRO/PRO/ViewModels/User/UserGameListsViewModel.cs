using PRO.Domain.HelperClasses;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRO.UI.ViewModels
{
    public class UserGameListsViewModel
    {
        public PaginatedList<GameList> GameLists { get; set; }
        public List<ListType> ListTypes { get; set; }
        public int? LoggedUserId { get; set; }
        public ApplicationUser AppUser { get; set; }
    }
}
