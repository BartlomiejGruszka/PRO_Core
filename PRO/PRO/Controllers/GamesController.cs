using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.HelperClasses;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using PRO.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using PRO.Domain.ExternalAPI.SteamAPI;
using System.Threading.Tasks;

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
        private readonly ISteamApi _steamApi;

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
            IUserListService userListService,
            ISteamApi steamApi
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
            _steamApi = steamApi;
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
        [AllowAnonymous]
        [Route("games/Filter")]
        public ActionResult Filter(string currentFilter, string value, int? page, int? items)
        {


            int? user = _userService.GetLoggedInUserId();
            var gamescores = _gameService.GetUserUnorderedGamesRanking(user).OrderBy(g => g.Game.Title).AsQueryable();
            var games = _gameService.FilterByProperty(currentFilter, value, gamescores);
            var paginatedgamescores = PaginatedList<GameScore>.Create(games.AsNoTracking(), page, items);
            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            paginatedgamescores.Pagination.Action = action;
            var viewModel = new GameFilterViewModel
            {
                GamesScores = paginatedgamescores
            };
            ViewData["CurrentFilter"] = currentFilter;
            ViewData["FilterValue"] = value;
            return View("Index", viewModel);
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
            var game = _gameService.FindActive(id);
            if (game == null) return NotFound();

            var DetailsModel = SetupDetails(id, null, null);
            var GameInfoModel = SetupGameInfo(game);
            DetailsModel.GameInfo = GameInfoModel;

            return View(DetailsModel);
        }

        [Route("games/details/{id}")]
        public ActionResult ManageDetails(int? id)
        {
            Game games = _gameService.Find(id);
            if (games == null) { return NotFound(); }
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

                return RedirectToAction("Manage");
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
            var gamesRankings = _gameService.GetUserUnorderedGamesRanking(_userService.GetLoggedInUserId()).OrderByDescending(s => s.Score).AsQueryable();
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
            var game = _gameService.FindActive(id);
            if (game == null) return NotFound();
            var DetailsModel = SetupDetails(id, page, items);
            var GameInfoModel = SetupGameInfo(game);
            DetailsModel.GameInfo = GameInfoModel;

            DetailsModel.ReviewPlaytimes.Pagination.Action = ControllerContext.ActionDescriptor.ActionName.ToString();
            DetailsModel.ReviewPlaytimes.Pagination.RouteId = id;
            return View(DetailsModel);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("games/{id}/reviews/{reviewid}")]
        public ActionResult SingleReview(int id, int? page, int? items, int reviewid)
        {
            var game = _gameService.FindActive(id);
            if (game == null) return NotFound();
            var DetailsModel = SetupDetails(id, page, items);
            var GameInfoModel = SetupGameInfo(game);
            DetailsModel.GameInfo = GameInfoModel;

            var reviews = new List<Review> { _reviewService.Find(reviewid) };
            var reviewplaytimes = _reviewService.ReviewPlaytimeList(reviews).AsQueryable();

            DetailsModel.ReviewPlaytimes = PaginatedList<ReviewPlaytime>.Create(reviewplaytimes.AsNoTracking(), page, items);

            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            DetailsModel.ReviewPlaytimes.Pagination.Action = action;

            if (DetailsModel.ReviewPlaytimes[0].Review.UserId == _userService.GetLoggedInUserId()) { ViewBag.CanEdit = true; } else { ViewBag.CanEdit = false; }

            return View(DetailsModel);
        }
        [HttpGet]
        [Authorize]
        [Route("games/{id}/userreview/")]
        public ActionResult UserReview(int id)
        {
            Review review = _reviewService.GetUserGameReview(_userService.GetLoggedInUserId(), id);
            if (review == null) review = new Review();
            var game = _gameService.FindActive(id);
            if (game == null) return NotFound();
            var DetailsModel = SetupDetails(id, null, null);
            var GameInfoModel = SetupGameInfo(game);
            DetailsModel.GameInfo = GameInfoModel;

            var reviews = new List<Review> { review };
            var reviewplaytimes = _reviewService.ReviewPlaytimeList(reviews).AsQueryable();

            DetailsModel.ReviewPlaytimes = PaginatedList<ReviewPlaytime>.Create(reviewplaytimes.AsNoTracking(), null, null);

            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            DetailsModel.ReviewPlaytimes.Pagination.Action = action;

            return View(DetailsModel);
        }

        [HttpGet]
        [Authorize]
        [Route("games/{id}/userreview/{reviewid}")]
        public ActionResult UserReview(int id, int reviewid)
        {
            Review review = _reviewService.Find(reviewid);
            var game = _gameService.FindActive(id);
            if (game == null || review == null) return NotFound();
            var DetailsModel = SetupDetails(id, null, null);
            var GameInfoModel = SetupGameInfo(game);
            DetailsModel.GameInfo = GameInfoModel;

            var reviews = new List<Review> { review };
            var reviewplaytimes = _reviewService.ReviewPlaytimeList(reviews).AsQueryable();

            DetailsModel.ReviewPlaytimes = PaginatedList<ReviewPlaytime>.Create(reviewplaytimes.AsNoTracking(), null, null);

            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            DetailsModel.ReviewPlaytimes.Pagination.Action = action;

            var userid = _userService.GetLoggedInUserId();
            if (review.UserId == userid) { ViewBag.CanEdit = true; } else { ViewBag.CanEdit = false; }
            return View(DetailsModel);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("games/search/{query?}")]
        public ActionResult Search(int? page, int? items, string query, string CurrentFilter)
        {
            if (query == null && CurrentFilter != null) query = CurrentFilter;
            var filteredgames = _gameService.GetFilteredGamesRanking(query).OrderBy(g => g.Game.Title).AsQueryable();

            var viewModel = new GameFilterViewModel
            {
                GamesScores = PaginatedList<GameScore>.Create(filteredgames.AsNoTracking(), page, items)
            };
            viewModel.GamesScores.Pagination.Action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            ViewData["CurrentFilter"] = query;
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

        private GameDetailsViewModel SetupDetails(int id, int? page, int? items)
        {
            var reviews = _reviewService.GetGameReviews(id);
            var reviewplaytimes = _reviewService.ReviewPlaytimeList(reviews).AsQueryable();

            var viewModel = new GameDetailsViewModel
            {
                ReviewPlaytimes = PaginatedList<ReviewPlaytime>.Create(reviewplaytimes.AsNoTracking(), page, items),
                RelevantArticles = _articleService.GetAll().Where(a => a.GameId == id).OrderByDescending(a => a.PublishedDate).Take(3)
            };
            return viewModel;
        }
        private GameInfoViewModel SetupGameInfo(Game game)
        {
            var GameInfo = new GameInfoViewModel
            {
                Game = game,
                UserLists = _userListService.GetUserUserLists(_userService.GetLoggedInUserId()).ToList(),
                Popularity = _gameService.GetGamePopularity(game.Id),
                Position = _gameService.GetGamePosition(game.Id),
                Rating = _gameService.GetGameRating(game.Id)
            };
            return GameInfo;
        }



    }
}