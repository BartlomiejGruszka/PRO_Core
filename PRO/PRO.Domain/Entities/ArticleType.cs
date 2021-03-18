using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRO.Entities
{
    public class ArticleType
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50), DisplayName("Rodzaj artykułu"), MinLength(3)] //add custom is unique constraint UniqueArticleTypeName
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}