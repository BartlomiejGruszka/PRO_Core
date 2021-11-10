﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class ListType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [IndexColumn("ListTypeName_IX", IsUnique = true)]
        [DisplayName("Nazwa")] //add custom is unique constraint UniqueListTypeName
        public string Name { get; set; }

        public ICollection<UserList> UserLists { get; set; }
    }
}