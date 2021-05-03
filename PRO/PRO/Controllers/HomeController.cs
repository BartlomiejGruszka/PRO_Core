using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using PRO.Domain.Interfaces.Services;
using PRO.Persistance.Data;
using PRO.UI.ViewModels;
using System.Linq;

namespace PRO.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IGameService _gameService;
        private readonly IReviewService _reviewService;
        private readonly IUserService _userService;
        private readonly ICompanyService _companyService;

        public HomeController(
            IArticleService articleService,
            IGameService gameService,
            IReviewService reviewService,
            IUserService userService,
            ICompanyService companyService
            )
        {
            _articleService = articleService;
            _gameService = gameService;
            _reviewService = reviewService;
            _userService = userService;
            _companyService = companyService;
        }

        public IActionResult NewIndex()
        {

            var test = _gameService.GetAll();
            var userId = User.GetLoggedInUserId<int>(); // Specify the type of your UserId;
            var userName = User.GetLoggedInUserName();
            //  var list =  test.Result;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                RecentGames = _gameService.GetAllActive().OrderByDescending(s=>s.ReleaseDate).Take(5).ToList(),
                RecentReviews = _reviewService.GetRecentReviews(),
                RecentArticles = _articleService.GetAllActive().OrderByDescending(s => s.PublishedDate).Take(5).ToList(),
                ComingGames = _gameService.GetComingGames(),
                MostPopularGames = _gameService.GetGamesByPopularity().Take(3).ToList(),
                BestRatedGames = _gameService.GetOrderedGamesRanking(3)
            };

            return View(homeViewModel);
        }

        [Route("search/{type?}")]
        public ActionResult Search(string searchString, string type)
        {
            if (string.IsNullOrEmpty(searchString)) { return RedirectToAction("Index"); }

            switch (type)
            {
                case "games":
                    return RedirectToAction("Search", "Games", new { query = searchString });
                case "articles":
                    return RedirectToAction("Search", "Articles", new { query = searchString });
                case "users":
                    //redirect to filtered list view of users
                    return RedirectToAction("Index");
                default:
                    return RedirectToAction("Index");
            }
        }

        public ActionResult GetFooter()
        {
            FooterViewModel footerViewModel = new FooterViewModel
            {
                HighestRatedGames = _gameService.GetOrderedGamesRanking(5),
                PopularCompanies = _companyService.GetPopularCompanies(5),
                RecentReviews = _reviewService.GetRecentReviews()
            };
            return PartialView("_Footer", footerViewModel);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}
