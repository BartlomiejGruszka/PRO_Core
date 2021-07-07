using PRO.Domain.HelperClasses;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRO.UI.ViewModels
{
    public class UserReviewsViewModel
    {
        public ApplicationUser AppUser { get; set; }
        public PaginatedList<ReviewPlaytime> ReviewsPlaytimes { get; set; }
    }
}
