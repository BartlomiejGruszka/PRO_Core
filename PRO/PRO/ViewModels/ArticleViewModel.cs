using System;
using System.Collections.Generic;
using PRO.Entities;

namespace PRO.UI.ViewModels
{
    public class ArticleViewModel
    {
        public IEnumerable<Image> Images { get; set; }
        public IEnumerable<ArticleType> ArticleTypes { get; set; }
        public IEnumerable<Game> Games { get; set; }
        public IEnumerable<Author> Authors { get; set; }
        public IEnumerable<ImageType> ImageTypes { get; set; }
        public int? SelectedImageTypeId { get; set; }

        public Article Article { get; set; }
    }
}