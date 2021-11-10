﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PRO.Entities
{
    public class Moderator
    {
        [Key, ForeignKey("User")]
        public int UserId { get; set; } //user fk and pk

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Data nadania roli")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Ostatnie logowanie")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? LastLoginDate { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Wciąż aktywny")]
        public bool IsActive { get; set; }

        public ICollection<Review> Reviews { get; set; }

        [DisplayName("Użytkownik")]
        public ApplicationUser User { get; set; }
    }
}