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
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;

namespace PRO.Controllers
{
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
        public ActionResult Index(int? page, int? items, string sortOrder,
               int[] Plat,
               int[] Stat,
               int[] Genr,
               int[] Seri,
               int[] Publ,
               int[] Deve,
               int[] Lang,
               int[] Tags)
        {
            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Title_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "Date_desc" : "Date";
            ViewData["PlatformSortParm"] = sortOrder == "Platform" ? "Platform_desc" : "Platform";
            ViewData["StatusSortParm"] = sortOrder == "Status" ? "Status_desc" : "Status";
            ViewData["ScoreSortParm"] = sortOrder == "Score" ? "Score_desc" : "Score";
            ViewData["UserscoreSortParm"] = sortOrder == "Userscore" ? "Userscore_desc" : "Userscore";

            var games = _gameService.FilterSearch(null, true);
            int? user = _userService.GetLoggedInUserId();
            var gamescores = _gameService.GetUserUnorderedGamesRanking(user, games).OrderBy(g => g.Game.Title).AsQueryable();
            gamescores = _gameService.GameSortList(sortOrder, gamescores);
            var paginatedgamescores = PaginatedList<GameScore>.Create(gamescores.AsNoTracking(), page, items);
            paginatedgamescores.Pagination.Configure(
                ControllerContext.ActionDescriptor.ActionName.ToString(), null, sortOrder);
            var viewModel = SetupViewModel(paginatedgamescores);
            return View(viewModel);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("games/filter")]
        public ActionResult MultiFilter(GamesViewModel viewModel)
        {
            var filterform = viewModel.GameFilterForm;


            string query = _gameService.ConstructFilterString(
                     filterform.SelectedPlatformsId,
                     filterform.SelectedStatusesId,
                     filterform.SelectedGenresId,
                     filterform.SelectedSeriesId,
                     filterform.SelectedPublishersId,
                     filterform.SelectedDevelopersId,
                     filterform.SelectedLanguagesId,
                     filterform.SelectedTagsId
                );
            return Redirect(query);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("games/filter")]
        public ActionResult Filter(string currentFilter, string value, string sortOrder, int? page, int? items)
        {
            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Title_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "Date_desc" : "Date";
            ViewData["PlatformSortParm"] = sortOrder == "Platform" ? "Platform_desc" : "Platform";
            ViewData["StatusSortParm"] = sortOrder == "Status" ? "Status_desc" : "Status";
            ViewData["ScoreSortParm"] = sortOrder == "Score" ? "Score_desc" : "Score";
            ViewData["UserscoreSortParm"] = sortOrder == "Userscore" ? "Userscore_desc" : "Userscore";


            int? user = _userService.GetLoggedInUserId();
            var gamescores = _gameService.GetUserUnorderedGamesRanking(user).OrderBy(g => g.Game.Title).AsQueryable();
            var games = _gameService.FilterByProperty(currentFilter, value, gamescores);
            var paginatedgamescores = PaginatedList<GameScore>.Create(games.AsNoTracking(), page, items);
            paginatedgamescores.Pagination.Configure(
                ControllerContext.ActionDescriptor.ActionName.ToString(), currentFilter, null);
            var viewModel = SetupViewModel(paginatedgamescores);
            ViewData["CurrentFilter"] = currentFilter;
            ViewData["FilterValue"] = value;
            return View("Index", viewModel);
        }
        public GamesViewModel SetupViewModel(PaginatedList<GameScore> gamescores)
        {
            return new GamesViewModel
            {
                Platforms = _platformService.GetAll(),
                Statuses = _statusService.GetAll(),
                Genres = _genreService.GetAll(),
                Series = _seriesService.GetAll(),
                Publishers = _companyService.GetAll(),
                Developers = _companyService.GetAll(),
                Languages = _languageService.GetAll(),
                Tags = _tagService.GetAll(),
                GamesScores = gamescores
            };
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Author")]
        [Route("games/manage")]
        public ActionResult Manage(int? page, int? items, string sortOrder, string currentFilter)
        {

            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Title_desc" : "";
            ViewData["PlatformSortParm"] = sortOrder == "Platform" ? "Platform_desc" : "Platform";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "Date_desc" : "Date";
            ViewData["StatusSortParm"] = sortOrder == "Status" ? "Status_desc" : "Status";
            ViewData["GenreSortParm"] = sortOrder == "Genre" ? "Genre_desc" : "Genre";

            var games = _gameService.FilterSearch(currentFilter, false);
            games = _gameService.SortList(sortOrder, games);

            var result = PaginatedList<Game>.Create(games.AsNoTracking(), page, items);
            result.Pagination.Configure(
                this.ControllerContext.ActionDescriptor.ActionName.ToString(), currentFilter, sortOrder);
            return View(result);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("games/{id}")]
        public ActionResult Details(int id)
        {
            var game = _gameService.FindActive(id);
            if (game == null) return NotFound();

            var viewModel = new GameDetailsViewModel
            {
                ReviewPlaytimes = _reviewService.PrepareReviews(_reviewService.GetGameReviews(id), null, null),
                RelevantArticles = _articleService.GetAll().Where(a => a.GameId == id).OrderByDescending(a => a.PublishedDate).Take(3),
                GameInfo = SetupGameInfo(game)
            };


            return View(viewModel);
        }

        [Authorize(Roles = "Admin,Author")]
        [Route("games/details/{id}")]
        public ActionResult ManageDetails(int? id)
        {
            var game = _gameService.Find(id);
            if (game == null) return NotFound();

            var viewModel = new GameDetailsViewModel
            {
                GameInfo = SetupGameInfo(game)
            };


            return View(viewModel);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Author")]
        [Route("games/add")]
        public ActionResult Add()
        {
            return View(GetFullGameForm(null));
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Author")]
        [Route("games/add")]
        public ActionResult Add(GameFormViewModel viewModel)
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
        [Authorize(Roles = "Admin,Author")]
        [Route("games/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            var gameViewModel = GetFullGameForm(id);

            if (gameViewModel.Game == null) return NotFound();

            return View(gameViewModel);

        }

        [HttpPost]
        [Authorize(Roles = "Admin,Author")]
        [Route("games/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GameFormViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _gameService.UpdateTags(viewModel.Game, viewModel.selectedTagsId);
                _gameService.UpdateLanguages(viewModel.Game, viewModel.selectedLanguagesId);
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
        public ActionResult Ranking(int? page, int? items, string currentFilter, string sortOrder)
        {
            var games = _gameService.GetAllActive().OrderBy(s => s.Title);
            var gamesRankings = _gameService.GetUserUnorderedGamesRanking(_userService.GetLoggedInUserId()).OrderByDescending(s => s.Score).ThenByDescending(c => c.Game.ReleaseDate).AsQueryable();
            var paginatedgamesrankings = PaginatedList<GameScore>.Create(gamesRankings.AsNoTracking(), page, items);
            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            paginatedgamesrankings.Pagination.Configure(action, currentFilter, sortOrder);
            var viewModel = new GamesViewModel
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
            var DetailsModel = new GameDetailsViewModel
            {
                ReviewPlaytimes = _reviewService.PrepareReviews(_reviewService.GetGameReviews(id), page, items),
                RelevantArticles = _articleService.GetAll().Where(a => a.GameId == id).OrderByDescending(a => a.PublishedDate).Take(3),
                GameInfo = SetupGameInfo(game)
            };

            DetailsModel.ReviewPlaytimes.Pagination.Configure(ControllerContext.ActionDescriptor.ActionName.ToString(), id);
            return View(DetailsModel);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("games/{id}/reviews/{reviewid}")]
        public ActionResult SingleReview(int id, int? page, int? items, int reviewid)
        {
            var game = _gameService.FindActive(id);
            if (game == null) return NotFound();
            var DetailsModel = new GameDetailsViewModel
            {
                ReviewPlaytimes = _reviewService.PrepareReviews(new List<Review> { _reviewService.Find(reviewid) }, page, items),
                RelevantArticles = _articleService.GetAll().Where(a => a.GameId == id).OrderByDescending(a => a.PublishedDate).Take(3),
                GameInfo = SetupGameInfo(game)
            };
            DetailsModel.ReviewPlaytimes.Pagination.Action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
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

            var DetailsModel = new GameDetailsViewModel
            {
                ReviewPlaytimes = _reviewService.PrepareReviews(new List<Review> { review }, null, null),
                RelevantArticles = _articleService.GetAll().Where(a => a.GameId == id).OrderByDescending(a => a.PublishedDate).Take(3),
                GameInfo = SetupGameInfo(game)
            };
            DetailsModel.ReviewPlaytimes.Pagination.Action = this.ControllerContext.ActionDescriptor.ActionName.ToString();

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

            var DetailsModel = new GameDetailsViewModel
            {
                ReviewPlaytimes = _reviewService.PrepareReviews(new List<Review> { review }, null, null),
                RelevantArticles = _articleService.GetAll().Where(a => a.GameId == id).OrderByDescending(a => a.PublishedDate).Take(3),
                GameInfo = SetupGameInfo(game)
            };
            DetailsModel.ReviewPlaytimes.Pagination.Action = this.ControllerContext.ActionDescriptor.ActionName.ToString();

            var userid = _userService.GetLoggedInUserId();
            if (review.UserId == userid) { ViewBag.CanEdit = true; } else { ViewBag.CanEdit = false; }
            return View(DetailsModel);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("games/search/{currentFilter?}")]
        public ActionResult Search(int? page, int? items, string currentFilter)
        {
            var filteredgames = _gameService.GetFilteredGamesRanking(currentFilter).OrderBy(g => g.Game.Title).AsQueryable();
            var gamescores = PaginatedList<GameScore>.Create(filteredgames.AsNoTracking(), page, items);
            var viewModel = SetupViewModel(gamescores);
            viewModel.GamesScores.Pagination.Configure(this.ControllerContext.ActionDescriptor.ActionName.ToString(), currentFilter, null);
            return View("Index", viewModel);
        }
        [HttpGet]
        [Authorize]
        [Route("games/userdelete")]
        public ActionResult UserDeleteReview(int? gameid, int? reviewid)
        {
            Review review = _reviewService.Find(reviewid);
            var game = _gameService.FindActive(gameid);
            if (game == null || review == null) return NotFound();

            var DetailsModel = new GameDetailsViewModel
            {
                GameInfo = SetupGameInfo(game),
                ReviewPlaytimes = _reviewService.PrepareReviews(new List<Review> { review }, null, null),
            };
            DetailsModel.ReviewPlaytimes.Pagination.Action = this.ControllerContext.ActionDescriptor.ActionName.ToString();

            return View("UserDeleteReview", DetailsModel);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Author")]
        [Route("games/getsteamgames/{letter?}")]
        public ActionResult GetSteamGames(string letter)
        {
            var steamgames = _steamApi.GetAllByLetter(letter);
            SelectList steamGamesList = new SelectList(steamgames, "appid", "name", 0);
            return Json(steamGamesList);
        }
        public GameFormViewModel GetFullGameForm(int? id)
        {
            List<int> selectedLanguagesId = null;
            List<int> selectedTagsId = null;
            var game = _gameService.Find(id);

            if (game != null)
            {
                selectedLanguagesId = game.Languages.Select(l => l.Id).ToList();
                selectedTagsId = game.Tags.Select(l => l.Id).ToList();
            }

            var gameViewModel = new GameFormViewModel
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
                ImageTypes = _imageTypeService.GetByType(ImageTypes.Game),
                FilterLetters = _steamApi.GetFilterLetters()
            };
            return gameViewModel;
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