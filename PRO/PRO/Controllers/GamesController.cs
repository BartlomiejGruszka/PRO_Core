using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Extensions;
using PRO.Domain.HelperClasses;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using PRO.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PRO.Controllers
{
    [Authorize(Roles = "Admin,Author")]
    public class GamesController : Controller
    {
        private readonly IGameService _gameService;
        private readonly IUserService _userService;
        private readonly IGenreService _genreService;
        private readonly IPlatformService _platformService;
        private readonly ISeriesService _seriesService;
        private readonly ICompanyService _companyService;
        private readonly IStatusService _statusService;
        private readonly IImageService _imageService;
        private readonly ILanguageService _languageService;
        private readonly ITagService _tagService;
        private readonly IImageTypeService _imageTypeService;
        private readonly IArticleService _articleService;
        private readonly IReviewService _reviewService;
        private readonly IGameListService _gameListService;
        private readonly IUserListService _userListService;
        public GamesController(
            IGameService gameService,
            IUserService userService,
            IGenreService genreService,
            IPlatformService platformService,
            ISeriesService seriesService,
            ICompanyService companyService,
            IStatusService statusService,
            IImageService imageService,
            ILanguageService languageService,
            ITagService tagService,
            IImageTypeService imageTypeService,
            IArticleService articleService,
            IReviewService reviewService,
            IGameListService gameListService,
            IUserListService userListService
            )
        {
            _gameService = gameService;
            _userService = userService;
            _genreService = genreService;
            _platformService = platformService;
            _seriesService = seriesService;
            _companyService = companyService;
            _statusService = statusService;
            _imageService = imageService;
            _languageService = languageService;
            _tagService = tagService;
            _imageTypeService = imageTypeService;
            _articleService = articleService;
            _reviewService = reviewService;
            _gameListService = gameListService;
            _userListService = userListService;
        }


        [AllowAnonymous]
        [Route("games/")]
        public ActionResult Index(int? page, int? items)
        {

            var games = _gameService.GetAllActive().OrderBy(g => g.Title).ToList();
            int? user = _userService.GetLoggedInUserId();
            var gamescores = _gameService.GetUserUnorderedGamesRanking(user).OrderBy(g => g.Game.Title).AsQueryable();
            var paginatedgamescores = PaginatedList<GameScore>.Create(gamescores.AsNoTracking(), page, items);
            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            paginatedgamescores.Pagination.Action = action;
            var viewModel = new GameFilterViewModel
            {
                GamesScores = paginatedgamescores
            };
            return View(viewModel);
        }

        [HttpGet]
        [Route("games/manage")]
        public ActionResult Manage(string query, int? page, int? items, string sortOrder, string currentFilter)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Title_desc" : "";
            ViewData["PlatformSortParm"] = sortOrder == "Platform" ? "Platform_desc" : "Platform";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "Date_desc" : "Date";
            ViewData["StatusSortParm"] = sortOrder == "Status" ? "Status_desc" : "Status";
            ViewData["GenreSortParm"] = sortOrder == "Genre" ? "Genre_desc" : "Genre";
            if (!String.IsNullOrEmpty(query))
            {
                page = 1;
            }
            else
            {
                query = currentFilter;
            }
            ViewData["CurrentFilter"] = query;

            var games = _gameService.FilterSearch(query);
            var test = games.ToList();
            games = _gameService.SortList(sortOrder, games);

             test = games.ToList();
 
            var result = PaginatedList<Game>.Create(games.AsNoTracking(), page, items);
            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            result.Pagination.Action = action;
            return View(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("games/{id}")]
        public ActionResult Details(int id)
        {
            var viewModel = SetupDetailsPage(id, null, null, null);
            if (viewModel == null) return NotFound();
            return View(viewModel);
        }

        [Route("games/details/{id}")]
        public ActionResult ManageDetails(int? id)
        {
            Game games = _gameService.Find(id);
            if (games == null){ return NotFound();}
            return View(games);
        }
        [HttpGet]
        [Route("games/add")]
        public ActionResult Add()
        {
            return View(GetFullGameForm(null));
        }

        [HttpPost]
        [Route("games/add")]
        public ActionResult Add(GameViewModel viewModel)
        {
            _gameService.AddTags(viewModel.Game, viewModel.selectedTagsId);
            _gameService.AddLanguages(viewModel.Game, viewModel.selectedLanguagesId);

            if (ModelState.IsValid)
            {
                _gameService.Add(viewModel.Game);
                return RedirectToAction("Manage");
            }
            var newViewModel = GetFullGameForm(null);
            newViewModel.Game = viewModel.Game;
            return View(newViewModel);
        }

        [HttpGet]
        [Route("games/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            var gameViewModel = GetFullGameForm(id);

            if (gameViewModel.Game == null) return NotFound();

            return View(gameViewModel);

        }

        [HttpPost]
        [Route("games/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GameViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _gameService.AddTags(viewModel.Game, viewModel.selectedTagsId);
                _gameService.AddLanguages(viewModel.Game, viewModel.selectedLanguagesId);
                _gameService.Update(viewModel.Game);

                var previouspage = HttpContext.Request.Headers["Referer"];
                if (string.IsNullOrEmpty(previouspage)) { return RedirectToAction("Details", new { id = viewModel.Game.Id }); }
                return Redirect(previouspage);
            }
            var gameViewModel = GetFullGameForm(viewModel.Game.Id);
            gameViewModel.Game = viewModel.Game;
            gameViewModel.selectedLanguagesId = viewModel.selectedLanguagesId;
            gameViewModel.selectedTagsId = viewModel.selectedTagsId;
            return View(gameViewModel);

        }

        // GET: Companies/Delete/5
        [HttpGet]
        [Route("games/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            Game game = _gameService.Find(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        [Route("games/delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Game game = _gameService.Find(id);
            _gameService.Delete(game);
            return RedirectToAction("Manage");
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("games/ranking")]
        public ActionResult Ranking(int? page, int? items)
        {
            var games = _gameService.GetAllActive().OrderBy(s => s.Title);
            var gamesRankings = _gameService.GetUserUnorderedGamesRanking(_userService.GetLoggedInUserId()).AsQueryable();
            var paginatedgamesrankings = PaginatedList<GameScore>.Create(gamesRankings.AsNoTracking(), page, items);
            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            paginatedgamesrankings.Pagination.Action = action;
            var viewModel = new GameFilterViewModel
            {
                GamesScores = paginatedgamesrankings
            };
            ViewBag.UserId = _userService.GetLoggedInUserId();
            return View(viewModel);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("games/reviews/{id}")]
        public ActionResult Reviews(int id, int? page, int? items)
        {        
            var model = SetupDetailsPage(id, null, page, items);
            
            if (model == null) return NotFound();
            model.ReviewPlaytimes.Pagination.Action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            model.ReviewPlaytimes.Pagination.RouteId = id;
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("games/{id}/reviews/{review}")]
        public ActionResult SingleReview(int id, int? page, int? items, int review)
        {
            var model = SetupDetailsPage(id, null, page, items);
            if (model == null) return NotFound();

            var selectedReview = _reviewService.Find(review);
            List<Review> Reviews = new List<Review>();
            Reviews.Add(selectedReview);

            var reviewplaytimes = _reviewService.ReviewPlaytimeList(Reviews).AsQueryable();
            model.ReviewPlaytimes = PaginatedList<ReviewPlaytime>.Create(reviewplaytimes.AsNoTracking(), page, items);
            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            model.ReviewPlaytimes.Pagination.Action = action;

            if (selectedReview.UserId == _userService.GetLoggedInUserId()) { ViewBag.CanEdit = true; } else { ViewBag.CanEdit = false; }
            return View(model);
        }
        [HttpGet]
        [Authorize]
        [Route("games/{id}/userreview")]
        public ActionResult UserReview(int id)
        {
            var model = SetupDetailsPage(id, null, null, null);
            model.ReviewPlaytimes.Pagination.Action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            if (model == null) return NotFound();

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("games/search/{query?}")]
        public ActionResult Search(int? page, int? items, string query)
        {
            var filteredgames = _gameService.GetFilteredGamesRanking(query).OrderBy(g => g.Game.Title).AsQueryable();

            var viewModel = new GameFilterViewModel
            {
                GamesScores = PaginatedList<GameScore>.Create(filteredgames.AsNoTracking(), page, items)
            };
            viewModel.GamesScores.Pagination.Action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            return View("Index", viewModel);
        }


        public GameViewModel GetFullGameForm(int? id)
        {
            List<int> selectedLanguagesId = null;
            List<int> selectedTagsId = null;
            var game = _gameService.Find(id);

            if (game != null)
            {
                selectedLanguagesId = game.Languages.Select(l => l.Id).ToList();
                selectedTagsId = game.Tags.Select(l => l.Id).ToList();
            }

            var gameViewModel = new GameViewModel
            {
                Platforms = _platformService.GetAll(),
                Statuses = _statusService.GetAll(),
                Genres = _genreService.GetAll(),
                Series = _seriesService.GetAll(),
                Publishers = _companyService.GetAll(),
                Developers = _companyService.GetAll(),
                Languages = _languageService.GetAll(),
                Tags = _tagService.GetAll(),
                Game = game,
                selectedLanguagesId = selectedLanguagesId,
                selectedTagsId = selectedTagsId,
                ImageTypes = _imageTypeService.GetByType(ImageTypes.Game)
            };
            return gameViewModel;
        }

        private GameDetailsViewModel SetupDetailsPage(int id, GameList gamelist, int? page, int? items)
        {
            //get game
            var game = _gameService.FindActive(id);
            if (game == null) return null;

            //get reviews and articles for the game, set pagination
            var reviews = _reviewService.GetGameReviews(game.Id);
            var reviewplaytimes = _reviewService.ReviewPlaytimeList(reviews).AsQueryable();

            //get userlists for logged user for quick add to list form
            var userid = _userService.GetLoggedInUserId();
            var userLists = _userListService.GetAll().Where(u => u.UserId == userid).ToList();

            var GameGameList = new GameAndGameListFormViewModel
            {
                Game = game,
                GameList = gamelist,
                UserLists = userLists,
                Popularity = _gameService.GetGamePopularity(game.Id),
                Position = _gameService.GetGamePosition(game.Id),
                Rating = _gameService.GetGameRating(game.Id)
            };
            var viewModel = new GameDetailsViewModel
            {
                GameGameList = GameGameList,
                ReviewPlaytimes = PaginatedList<ReviewPlaytime>.Create(reviewplaytimes.AsNoTracking(), page, items),
                RelevantArticles = _articleService.GetAll().Where(a => a.GameId == id).OrderByDescending(a => a.PublishedDate).Take(3)
            };
            return viewModel;
        }
    }
}