
using System.Collections.Generic;
using System.Linq;
using PRO.UI.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRO.Entities;
using PRO.Domain.Interfaces.Services;

namespace PRO.Controllers
{

    public class ArticlesController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IGameService _gameService;
        private readonly IGameListService _gameListService;
        private readonly IReviewService _reviewService;
        private readonly IUserService _userService;
        private readonly IImageService _imageService;
        private readonly IArticleTypeService _articleTypeService;
        private readonly IAuthorService _authorService;
        private readonly IImageTypeService _imageTypeService;

        public ArticlesController(
            IArticleService articleService,
            IGameService gameService,
            IGameListService gameListService,
            IReviewService reviewService,
            IUserService userService,
            IImageService imageService,
            IArticleTypeService articleTypeService,
            IAuthorService authorService,
            IImageTypeService imageTypeService
            )
        {
            _articleService = articleService;
            _gameService = gameService;
            _gameListService = gameListService;
            _reviewService = reviewService;
            _userService = userService;
            _imageService = imageService;
            _articleTypeService = articleTypeService;
            _authorService = authorService;
            _imageTypeService = imageTypeService;
        }

        [AllowAnonymous]
        [Route("articles/")]
        public ActionResult Index(int? page, int? items, string platform)
        {


            IEnumerable<Article> articlesList = new List<Article>();
            IEnumerable<Article> otherArticles = new List<Article>();
            if (platform == null || platform == "all")
            {
                articlesList = _articleService.GetAllActive();
            }
            else if (platform == "other")
            {
                otherArticles = _articleService.GetAllActive(); ;
                articlesList = otherArticles
                .Where(i =>
                          !i.Game.Platform.Name.Contains("PC")
                        & !i.Game.Platform.Name.Contains("Playstation")
                        & !i.Game.Platform.Name.Contains("Xbox")
                        & !i.Game.Platform.Name.Contains("Switch"))
                .OrderByDescending(d => d.PublishedDate)
                .ToList();

            }
            else
            {
                articlesList = _articleService.GetAllByPlatform(platform);
            }

            ViewBag.Pagination = new Pagination(page, items, articlesList.Count());
            ViewBag.Platform = platform;
            return View(articlesList);
        }

        [Route("articles/manage")]
        [Authorize(Roles = "Admin,Author")]
        public ActionResult Manage(int? page, int? items)
        {
            IEnumerable<Article> articlesList = null;

            if (!User.IsInRole("Admin"))
            {
                articlesList = _articleService.GetAll().Where(s => s.Author.UserId == _userService.GetLoggedInUserId());
            }
            else
            {
                articlesList = _articleService.GetAll();
            }

            ViewBag.Pagination = new Pagination(page, items, articlesList.Count());
            return View(articlesList);
        }

        [AllowAnonymous]
        [Route("articles/{id}")]
        public ActionResult Details(int? id)
        {

            ArticleDetailsViewModel articleDetails = new ArticleDetailsViewModel
            {
                Article = _articleService.FindActive(id),
                RecentGames = _gameService.GetComingGames(),
                RecentReviews = _reviewService.GetRecentReviews(),
                BestRatedGames = _gameService.GetOrderedGamesRanking(3)
            };
            if (articleDetails.Article == null)
            {
                return NotFound();
            }
            return View(articleDetails);
        }


        [Route("articles/details/{id}")]
        [Authorize(Roles = "Admin,Author")]
        public ActionResult ManageDetails(int? id)
        {

            var article = _articleService.Find(id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        [Route("articles/add")]
        [Authorize(Roles = "Admin,Author")]
        public ActionResult Add()
        {

            var viewModel = PopulateArticleViewModel(null);
            return View(viewModel);
        }


        [HttpPost]
        [Route("articles/add")]
        [Authorize(Roles = "Admin,Author")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Article article)
        {
            if (ModelState.IsValid)
            {
                var userid = _userService.GetLoggedInUserId();
                if (userid == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                if (_authorService.Find(userid) == null)
                {
                    return NotFound();
                }
                _articleService.Add(article, userid);
                return RedirectToAction("Manage");
            }
            var articleViewModel = PopulateArticleViewModel(null);
            articleViewModel.Article = article;
            return View(articleViewModel);
        }

        [Route("articles/edit/{id}")]
        [Authorize(Roles = "Admin,Author")]
        public ActionResult Edit(int? id)
        {
            ArticleViewModel articleViewModel = PopulateArticleViewModel(id);
            if (articleViewModel.Article == null)
            {
                return NotFound();
            }
            if (
                articleViewModel.Article.UserId != _userService.GetLoggedInUserId()
                && !User.IsInRole("Admin")
                )
            {
                RedirectToAction("Manage");
            }

            return View(articleViewModel);
        }

        [HttpPost]
        [Route("articles/edit/{id}")]
        [Authorize(Roles = "Admin,Author")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ArticleViewModel articleViewModel)
        {
            if (
                articleViewModel.Article.UserId != _userService.GetLoggedInUserId()
                && !User.IsInRole("Admin")
                )
            {
                RedirectToAction("Manage");
            }
            if (ModelState.IsValid)
            {
                _articleService.Update(articleViewModel.Article);
                return RedirectToAction("Manage");
            }
            articleViewModel = PopulateArticleViewModel(articleViewModel.Article.Id);
            return View(articleViewModel);
        }

        [Route("articles/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            Article article = _articleService.Find(id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        // POST: Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("articles/delete/{id}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article article = _articleService.Find(id);
            _articleService.Delete(article);
            return RedirectToAction("Manage");
        }

        [AllowAnonymous]
        [Route("articles/search/{query?}")]
        public ActionResult Search(string query, int? page, int? items)
        {
            var searchList = _articleService.SearchResultArticles(query);

            ViewBag.Pagination = new Pagination(page, items, searchList.Count());
            ViewBag.Query = query;
            ViewBag.platform = "none";
            return View(searchList);
        }

        public ArticleViewModel PopulateArticleViewModel (int? id)
        {
            var article = _articleService.Find(id);
            var viewModel = new ArticleViewModel
            {
                Images = _imageService.GetAll(),
                ArticleTypes = _articleTypeService.GetAll(),
                Games = _gameService.GetAll(),
                Authors = _authorService.GetAll(),
                Article = article,
                ImageTypes = _imageTypeService.GetAll()

            };
            return viewModel;

        }

    }
}