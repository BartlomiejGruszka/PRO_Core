﻿
using System.Collections.Generic;
using PRO.Entities;
namespace PRO.UI.ViewModels
{
    public class GameViewModel
    {
        public IEnumerable<Platform> Platforms { get; set; }
        public IEnumerable<Status> Statuses{ get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Series> Series { get; set; }
        public IEnumerable<Company> Publishers { get; set; }
        public IEnumerable<Company> Developers { get; set; }
        public IEnumerable<Image> Images{ get; set; }
        public IEnumerable<ImageType> ImageTypes { get; set; }
        public IEnumerable<Language> Languages{ get; set; }
        public IEnumerable<Tag> Tags{ get; set; }
        public IEnumerable<int> selectedLanguagesId { get; set; }
        public IEnumerable<int> selectedTagsId { get; set; }
        public int? SelectedImageTypeId { get; set; }
        public Game Game { get; set; }
    }
}