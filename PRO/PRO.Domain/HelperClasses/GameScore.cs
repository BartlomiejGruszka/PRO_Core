﻿using PRO.Domain.Entities;

namespace PRO.Domain.HelperClasses
{
   public class GameScore
    {
        public Game Game { get; set; }
        public double? Score { get; set; }

        public int? UserScore { get; set; }
    }
}
