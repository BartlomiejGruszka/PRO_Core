using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRO.UI.ViewModels
{
    public class UserGameListFormViewModel
    {
        public ApplicationUser AppUser { get; set; }
        public GameList GameList { get; set; }
    }
}
