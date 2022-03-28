using System;
using System.Collections.Generic;
using System.ComponentModel;
using PRO.Domain.HelperClasses;
using PRO.Entities;
namespace PRO.UI.ViewModels
{
    public class GameFilterViewModel
    {
        [DisplayName("Platforma")]
        public IEnumerable<Platform> Platforms { get; set; }

        [DisplayName("Status")]
        public IEnumerable<Status> Statuses { get; set; }

        [DisplayName("Gatunek")]
        public IEnumerable<Genre> Genres { get; set; }

        [DisplayName("Seria")]
        public IEnumerable<Series> Series { get; set; }

        [DisplayName("Wydawca")]
        public IEnumerable<Company> Publishers { get; set; }

        [DisplayName("Producent")]
        public IEnumerable<Company> Developers { get; set; }

        [DisplayName("Języki")]
        public IEnumerable<Language> Languages { get; set; }

        [DisplayName("Tagi")]
        public IEnumerable<Tag> Tags { get; set; }


        public IEnumerable<int> SelectedPlatformsId { get; set; }
        public IEnumerable<int> SelectedStatusesId { get; set; }
        public IEnumerable<int> SelectedGenresId { get; set; }
        public IEnumerable<int> SelectedSeriesId { get; set; }
        public IEnumerable<int> SelectedPublishersId { get; set; }
        public IEnumerable<int> SelectedDevelopersId { get; set; }
        public IEnumerable<int> SelectedLanguagesId { get; set; }
        public IEnumerable<int> SelectedTagsId { get; set; }

        public PaginatedList<GameScore> GamesScores { get; set; }
    }
}