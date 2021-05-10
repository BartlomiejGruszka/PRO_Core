using System;
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

        [IndexColumn(nameof(Name), IsUnique = true)]
        [Required, DisplayName("Nazwa"), MaxLength(50), MinLength(3)] //add custom is unique constraint UniqueListTypeName
        public string Name { get; set; }

        public ICollection<UserList> UserLists { get; set; }
    }
}