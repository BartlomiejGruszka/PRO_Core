using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class ArticleType
    {
        [Key]
        public int Id { get; set; }

        [Required, IndexColumn(nameof(Name), IsUnique = true), MaxLength(50), DisplayName("Rodzaj artykułu"), MinLength(3)] //add custom is unique constraint UniqueArticleTypeName
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}