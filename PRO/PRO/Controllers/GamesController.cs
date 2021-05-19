﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Extensions;
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
            var gamescores = _gameService.GetUnorderedGamesRanking().OrderBy(g => g.Item1.Title);
            var viewModel = new GameFilterViewModel
            {
                Games = games,
                GameScores = gamescores
            };
            ViewBag.Pagination = new Pagination(page, items, games.Count());
            return View(viewModel);
        }

        [HttpGet]
        [Route("games/manage")]
        public ActionResult Manage(int? page, int? items)
        {

            var games = _gameService.GetAll();

            ViewBag.Pagination = new Pagination(page, items, games.Count());
            return View(games);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("games/{id}")]
        public ActionResult Details(int id)
        {
            var viewModel = SetupDetailsPage(id, null);
            return View(viewModel);
        }

        private GameDetailsViewModel SetupDetailsPage(int id, GameList gamelist)
        {
            //get game
            var game = _gameService.FindActive(id);
            if (game == null) return null;

            //get reviews and articles for the game, set pagination
            var reviews = _reviewService.GetGameReviews(game.Id);
            ViewBag.Pagination = new Pagination(null, null, reviews.Count());

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
                ReviewGametimes = _reviewService.ReviewPlaytimeList(reviews),
                RelevantArticles = _articleService.GetAll().Where(a => a.GameId == id).OrderByDescending(a => a.PublishedDate).Take(3)
            };
            return viewModel;
        }


        [Route("games/details/{id}")]
        public ActionResult ManageDetails(int? id)
        {
            Game games = _gameService.Find(id);
            if (games == null)
            {
                return NotFound();
            }
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
            var gamesRankings = _gameService.GetOrderedGamesRanking(null);
            var viewModel = new GameFilterViewModel
            {
                Games = games,
                GameScores = gamesRankings
            };
            ViewBag.Pagination = new Pagination(page, items, games.Count());
            return View(viewModel);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("games/{id}/reviews")]
        public ActionResult Reviews(int id, int? page, int? items)
        {
            var game = _gameService.FindActive(id);
            if (game == null) return NotFound();
            ViewBag.Pagination = new Pagination(page, items, game.Reviews.Count());

            var model = SetupDetailsPage(id, null);

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("games/{id}/reviews/{review}")]
        public ActionResult SingleReview(int id, int? page, int? items, int review)
        {
            var game = _gameService.FindActive(id);
            if (game == null) return NotFound();
            var selectedReview = _reviewService.Find(review);
            ViewBag.Pagination = new Pagination(page, items, 1);
            List<Review> Reviews = new List<Review>();
            Reviews.Add(selectedReview);
            var model = SetupDetailsPage(id, null);
            model.ReviewGametimes = _reviewService.ReviewPlaytimeList(Reviews);
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("games/search/{query?}")]
        public ActionResult Search(int? page, int? items, string query)
        {
            var filteredgames = _gameService.FilterGames(query);

            var viewModel = new GameFilterViewModel
            {
                Games = filteredgames,
                GameScores = _gameService.GetUnorderedGamesRanking().OrderBy(g => g.Item1.Title)
            };
            ViewBag.Pagination = new Pagination(page, items, filteredgames.Count());
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

    }
}