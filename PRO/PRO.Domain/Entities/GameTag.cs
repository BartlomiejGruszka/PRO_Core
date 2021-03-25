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

        [Required]
        public int GameId { get; set; }

        public Game Game { get; set; }


        [Required]
        public int TagId { get; set; }

        public Tag Tag { get; set; }
    }
}