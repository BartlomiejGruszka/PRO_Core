using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Domain.Entities
{
    public class Award
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [IndexColumn("AwardName_IX", IsUnique = true), DisplayName("Nazwa nagrody")] //add custom is unique constraint UniqueAwardName
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Data nadania")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AwardDate { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Nagrodzona gra")]
        public int GameId { get; set; }

        [ForeignKey("GameId"),DisplayName("Nagrodzona gra")]
        public Game Game { get; set; }


    }
}