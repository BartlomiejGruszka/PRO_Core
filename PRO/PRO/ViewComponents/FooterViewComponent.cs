using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Interfaces.Services;
using PRO.UI.ViewModels;


namespace PRO.UI.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly IGameService _gameService;
        private readonly IReviewService _reviewService;
        private readonly ICompanyService _companyService;

        public FooterViewComponent(
            IGameService gameService,
            IReviewService reviewService,
            ICompanyService companyService
            )
        {
            _gameService = gameService;
            _reviewService = reviewService;
            _companyService = companyService;
        }
        public IViewComponentResult Invoke()
        {
            FooterViewModel footerViewModel = new FooterViewModel
            {
                HighestRatedGames = _gameService.GetOrderedGamesRanking(5),
                PopularCompanies = _companyService.GetPopularCompanies(5),
                RecentReviews = _reviewService.GetRecentReviews()
            };
            return View("_Footer", footerViewModel);
        }
    }
}
