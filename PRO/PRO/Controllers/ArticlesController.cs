
using System.Collections.Generic;
using System.Linq;
using PRO.UI.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRO.Entities;
using PRO.Domain.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using System;

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
        public ActionResult Index(int? page, int? items, string query, string currentFilter)
        {
            if (!String.IsNullOrEmpty(query))
            {
                page = 1;
            }
            else
            {
                query = currentFilter;
            }
            ViewData["CurrentFilter"] = query;
            var articlesList = _articleService.ArticlesByPlatform(query).AsQueryable();
            var result = PaginatedList<Article>.Create(articlesList.AsNoTracking(), page, items);
            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            result.Pagination.Action = action;
            return View(result);
        }

        [Route("articles/manage")]
        [Authorize(Roles = "Admin,Author")]
        public ActionResult Manage(string query, int? page, int? items, string sortOrder, string currentFilter)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["GameSortParm"] = sortOrder == "Game" ? "game_desc" : "Game";

            if (!String.IsNullOrEmpty(query))
            {
                page = 1;
            }
            else
            {
                query = currentFilter;
            }
            ViewData["CurrentFilter"] = query;

            IQueryable<Article> articlesList = null;

            if (!User.IsInRole("Admin"))
            {
                articlesList = _articleService.GetAllForAuthor(query,_userService.GetLoggedInUserId()).AsQueryable();
            }
            else
            {
                articlesList = _articleService.GetAllForAdmin(query).AsQueryable();
            }
            var sorted = _articleService.SortList(sortOrder, articlesList);
            var result = PaginatedList<Article>.Create(sorted.AsNoTracking(), page, items);
            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            result.Pagination.Action = action;
            return View(result);
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
            var articleViewModel = PopulateArticleViewModel(id);
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
        public ActionResult Search(string query, int? page, int? items, string currentFilter)
        {
            if (!String.IsNullOrEmpty(query))
            {
                page = 1;
            }
            else
            {
                query = currentFilter;
            }
            ViewData["CurrentFilter"] = query;
            var searchList = _articleService.SearchResultArticles(null,query).AsQueryable();
            var result = PaginatedList<Article>.Create(searchList.AsNoTracking(), page, items);
            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            result.Pagination.Action = action;
            return View(result);
        }

        public ArticleViewModel PopulateArticleViewModel (int? id)
        {
            var article = _articleService.Find(id);
            var viewModel = new ArticleViewModel
            {
                ArticleTypes = _articleTypeService.GetAll(),
                Games = _gameService.GetAll(),
                Authors = _authorService.GetAll(),
                Article = article,
                ImageTypes = _imageTypeService.GetByType(ImageTypes.Article)

            };
            return viewModel;

        }

    }
}