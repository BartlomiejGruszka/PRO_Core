using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.HelperClasses
{
   public class GameScore
    {
        public Game Game { get; set; }
        public double? Score { get; set; }

        public int? UserScore { get; set; }
    }
}
