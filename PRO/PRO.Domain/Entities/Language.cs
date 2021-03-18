using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PRO.Entities
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        [Required, DisplayName("Nazwa"), MaxLength(50), MinLength(3)] //add custom is unique constraint UniqueListTypeName
        public string Name { get; set; }

        public ICollection<GameLanguage> GameLanguages{ get; set; }

    }
}