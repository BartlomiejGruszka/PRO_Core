using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRO.Domain.Entities
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 100, MinimumLength = 10, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DisplayName("Tytuł")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 400, MinimumLength = 100, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DisplayName("Skrót")]
        public string Preview { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 10000, MinimumLength = 100, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DisplayName("Treść")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Data publikacji")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PublishedDate { get; set; }

        [StringLength(maximumLength: 255, MinimumLength = 0, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DisplayName("Link źródłowy")]
        public string SourceLink { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Widoczny")]
        public bool IsActive { get; set; }

        public int? ImageId { get; set; }

        [ForeignKey("ImageId"), DisplayName("Obraz")]
        public Image Image { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Gra")]
        public int GameId { get; set; }

        [ForeignKey("GameId"),DisplayName("Gra")]
        public Game Game { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public Author Author { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Rodzaj artykułu")]
        public int ArticleTypeId { get; set; }

        [ForeignKey("ArticleTypeId"),DisplayName("Rodzaj artykułu")]
        public ArticleType ArticleType { get; set; }


    }
}