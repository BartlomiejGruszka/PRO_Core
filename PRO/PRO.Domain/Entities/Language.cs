using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class Language
    {
        [Key]
        public int Id { get; set; }

        [IndexColumn("LanguageName_IX", IsUnique = true)]
        [Required, DisplayName("Nazwa"), MaxLength(50), MinLength(3)] //add custom is unique constraint UniqueListTypeName
        public string Name { get; set; }

        public ICollection<Game> Games{ get; set; }

    }
}