using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PRO.Entities
{
    public class GameTag
    {

        [Required(ErrorMessage = "Please enter value for {0}.")]
        public int GameId { get; set; }

        public Game Game { get; set; }


        [Required(ErrorMessage = "Please enter value for {0}.")]
        public int TagId { get; set; }

        public Tag Tag { get; set; }
    }
}