using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Extensions;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using PRO.UI.ViewModels;
using System.Linq;
namespace PRO.UI.ViewComponents
{
    public class GamesMultiFilterFormViewComponent : ViewComponent
    {
        private readonly IGameService _gameService;
        private readonly IGenreService _genreService;
        private readonly IPlatformService _platformService;
        private readonly ISeriesService _seriesService;
        private readonly ICompanyService _companyService;
        private readonly IStatusService _statusService;
        private readonly ILanguageService _languageService;
        private readonly ITagService _tagService;


        public GamesMultiFilterFormViewComponent(
            IGameService gameService,
            IGenreService genreService,
            IPlatformService platformService,
            ISeriesService seriesService,
            ICompanyService companyService,
            IStatusService statusService,
            ILanguageService languageService,
            ITagService tagService

            )
        {
            _gameService = gameService;
            _genreService = genreService;
            _platformService = platformService;
            _seriesService = seriesService;
            _companyService = companyService;
            _statusService = statusService;
            _languageService = languageService;
            _tagService = tagService;

        }

        public IViewComponentResult Invoke()
        {
            var form = new GamesViewModel
            {
                Platforms = _platformService.GetAll(),
                Genres = _genreService.GetAll(),
                Series = _seriesService.GetAll(),
                Developers = _companyService.GetAll(),
                Publishers = _companyService.GetAll(),
                Statuses = _statusService.GetAll(),
                Languages = _languageService.GetAll(),
                Tags = _tagService.GetAll(),
            };

            return View("_GamesMultiFilterForm", form);
        }

    }
}
