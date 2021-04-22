using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRO.Entities
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole \"Tytuł\" jest wymagane."), MaxLength(100), DisplayName("Tytuł"),MinLength(10)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Pole \"Skrót\" jest wymagane."), MaxLength(400), DisplayName("Skrót"), MinLength(100)]
        public string Preview { get; set; }

        [Required(ErrorMessage = "Pole \"Treść\" jest wymagane."), MaxLength(10000), DisplayName("Treść"),MinLength(100)]
        public string Content { get; set; }

        [Required(ErrorMessage = "Pole \"Data publikacji\" jest wymagane."), DisplayName("Data publikacji")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PublishedDate { get; set; }

        [MaxLength(255), DisplayName("Link źródłowy")]
        public string SourceLink { get; set; }


        [Required, DisplayName("Widoczny")]
        public bool IsActive { get; set; }

        public int? ImageId { get; set; }

        [ForeignKey("ImageId")]
        public Image Image { get; set; }

        [Required(ErrorMessage = "Pole \"Gra\" jest wymagane."), DisplayName("Gra")]
        public int GameId { get; set; }

        [ForeignKey("GameId"),DisplayName("Gra")]
        public Game Game { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public Author Author { get; set; }

        [Required(ErrorMessage = "Pole \"Rodzaj artykułu\" jest wymagane."), DisplayName("Rodzaj artykułu")]
        public int ArticleTypeId { get; set; }

        [ForeignKey("ArticleTypeId"),DisplayName("Rodzaj artykułu")]
        public ArticleType ArticleType { get; set; }


    }
}