﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PRO.Entities
{
    public class GameLanguage
    {
        [Required(ErrorMessage = "Please enter value for {0}.")]
        public int GameId { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        public int LanguageId { get; set; }


        public Game Game { get; set; }
        public Language Language { get; set; }
    }
}