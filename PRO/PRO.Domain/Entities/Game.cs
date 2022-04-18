using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRO.Domain.Entities
{
    public class Game
    {

        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DisplayName("Tytuł")]
        public string Title { get; set; }

        [MaxLength(1000), DisplayName("Opis")]
        public string Description { get; set; }


        [DataType(DataType.Date), DisplayName("Data premiery")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Wciąż dostępna")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [ DisplayName("Platforma")]
        public int PlatformId { get; set; }

        [ForeignKey("PlatformId"), DisplayName("Platforma")]
        public Platform Platform { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [ DisplayName("Status")]
        public int StatusId { get; set; }

        [ForeignKey("StatusId"), DisplayName("Status")]
        public Status Status { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Gatunek")]
        public int GenreId { get; set; }

        [ForeignKey("GenreId"), DisplayName("Gatunek")]
        public Genre Genre { get; set; }

        [ForeignKey("SeriesId"), DisplayName("Seria")]
        public Series Series { get; set; }
        public int? SeriesId { get; set; }


        [ForeignKey("ImageId"), DisplayName("Obraz")]
        public Image Image { get; set; }
        public int? ImageId { get; set; }

        public int? PublisherId { get; set; }

        [ForeignKey("PublisherId"), InverseProperty("PublishedGames"), DisplayName("Wydawca")]

        public Company PublisherCompany { get; set; }

        public int? DeveloperId { get; set; }

        [ForeignKey("DeveloperId"), InverseProperty("DevelopedGames"), DisplayName("Producent")]
        public Company DeveloperCompany { get; set; }

        [DisplayName("Identyfikator Steam")]
        public int? SteamAppId { get; set; }

        [DisplayName("Języki")]
        public ICollection<Language> Languages { get; set; }

        [DisplayName("Tagi")]
        public ICollection<Tag> Tags { get; set; }

        public ICollection<Award> Awards { get; set; }

        public ICollection<Article> Articles { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<GameList> GameLists { get; set; }

    }
}