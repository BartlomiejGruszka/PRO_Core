﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PRO.Entities
{
    public class Series
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100), DisplayName("Tytuł serii"), MinLength(3)] //add custom is unique constraint UniqueSeriesName
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}