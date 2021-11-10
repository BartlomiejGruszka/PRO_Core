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

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 5000, MinimumLength = 10, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DisplayName("Treść")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Data recenzji")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReviewDate { get; set; }

        [DisplayName("Data edycji")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EditDate { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [Range(1, 10, ErrorMessage = "'{0}' value must be between {1} and {2}.")]
        [DisplayName("Grafika")]
        public int GraphicsScore { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [Range(1, 10, ErrorMessage = "'{0}' value must be between {1} and {2}.")]
        [DisplayName("Fabuła")]
        public int StoryScore { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [Range(1, 10, ErrorMessage = "'{0}' value must be between {1} and {2}.")]
        [DisplayName("Muzyka")]
        public int MusicScore { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [Range(1, 10, ErrorMessage = "'{0}' value must be between {1} and {2}.")]
        [DisplayName("Grywalność")]
        public int GameplayScore { get; set; }

        [DisplayName("Zweryfikowany posiadacz")]
        public bool IsVerifiedOwner { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [IndexColumn("UniqueReview_IX", 1, IsUnique = true)]
        public int UserId { get; set; }

        [ForeignKey("UserId"), DisplayName("Użytkownik")]
        public ApplicationUser User { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [IndexColumn("UniqueReview_IX", 2, IsUnique = true)]
        public int GameId { get; set; }

        [ForeignKey("GameId"), DisplayName("Gra")]
        public Game Game { get; set; }

        public int? ModeratorId { get; set; }


        [ForeignKey("ModeratorId"), DisplayName("Moderator")]
        public Moderator Moderator { get; set; }


    }
}