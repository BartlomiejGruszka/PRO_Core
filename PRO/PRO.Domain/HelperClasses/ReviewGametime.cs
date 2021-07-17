using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.HelperClasses
{
    public class ReviewPlaytime
    {
        public Review Review { get; set; }

        public int? Playtime { get; set; }

        public bool VerifiedOwner { get; set; }
    }
}
