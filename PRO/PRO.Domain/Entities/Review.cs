using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(5000), DisplayName("Treść"), MinLength(10)]
        public string Content { get; set; }

        [Required, DisplayName("Data recenzji")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReviewDate { get; set; }

        [DisplayName("Data edycji")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EditDate { get; set; }

        [Required, Range(1, 10), DisplayName("Grafika")]
        public int GraphicsScore { get; set; }
        [Required, Range(1, 10), DisplayName("Fabuła")]
        public int StoryScore { get; set; }
        [Required, Range(1, 10), DisplayName("Muzyka")]
        public int MusicScore { get; set; }
        [Required, Range(1, 10), DisplayName("Grywalność")]
        public int GameplayScore { get; set; }

        [Required]
        [IndexColumn("UniqueReview_IX", 1, IsUnique = true)]
        public int UserId { get; set; }

        [ForeignKey("UserId"), DisplayName("Użytkownik")]
        public ApplicationUser User { get; set; }

        [Required]
        [IndexColumn("UniqueReview_IX", 2, IsUnique = true)]
        public int GameId { get; set; }

        [ForeignKey("GameId"), DisplayName("Gra")]
        public Game Game { get; set; }

        public int? ModeratorId { get; set; }

        
        [ForeignKey("ModeratorId"), DisplayName("Moderator")]
        public Moderator Moderator{ get; set; }


    }
}