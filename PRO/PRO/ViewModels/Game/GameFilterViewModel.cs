using System.Collections.Generic;

namespace PRO.UI.ViewModels
{
    public class GameFilterViewModel
    {
        public IEnumerable<int> SelectedPlatformsId { get; set; }
        public IEnumerable<int> SelectedStatusesId { get; set; }
        public IEnumerable<int> SelectedGenresId { get; set; }
        public IEnumerable<int> SelectedSeriesId { get; set; }
        public IEnumerable<int> SelectedPublishersId { get; set; }
        public IEnumerable<int> SelectedDevelopersId { get; set; }
        public IEnumerable<int> SelectedLanguagesId { get; set; }
        public IEnumerable<int> SelectedTagsId { get; set; }
    }
}
