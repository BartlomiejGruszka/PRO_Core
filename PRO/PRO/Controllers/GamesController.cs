using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Extensions;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using PRO.ViewModels;
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
        public GamesController(IGameService gameService, IUserService userService)
        {
            _gameService = gameService;
            _userService = userService;
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
           // Session["CurrentUrl"] = Request.Url.ToString();
            return View(viewModel);
        }

       // [ChildActionOnly] requires rework
        [HttpGet]
        public ActionResult AddGameToList(int id)
        {

          /*  var userid = _userService.GetLoggedInUserId();
            var userLists = _context.UserLists.Where(u => u.UserId == userid).ToList();

            var gameList = TempData["gameList"] as GameList;

            if (gameList == null) { gameList = _context.GameLists.Include(u => u.UserList).SingleOrDefault(g => g.GameId == id && g.UserList.UserId == userid); }
            if (gameList == null) { gameList = new GameList(); }

            var errors = TempData["errors"] as List<KeyValuePair<string, ModelState>>;
            if (errors != null)
            {
                foreach (var error in errors)
                {
                    var keyerror = error.Key;
                    if (error.Value.Errors.Count() > 0)
                    {
                        foreach(var value in error.Value.Errors)
                        {
                            ModelState.AddModelError(keyerror, value.ErrorMessage);
                        }
                    }
                }
            }
            ViewBag.userLists = userLists;
            ViewBag.GameId = id;
          */
            return PartialView("_AddGameToListForm", null);
        }


        [HttpPost]//requires rework
        public ActionResult AddGameToList(int id, [Bind("Id,HoursPlayed,PersonalScore,UserListId,GameId")] GameList gameList)
        {

            /*var userid = _userService.GetLoggedInUserId();
            var oldGameList = _context.GameLists.SingleOrDefault(s=>s.Id == gameList.Id);
            var userLists = _context.UserLists.Where(u => u.UserId == userid).ToList();

            if (gameList.UserListId <= 0)
            {
                if (Session["CurrentUrl"] == null) { return RedirectToAction("Details"); }
                return Redirect((string)Session["CurrentUrl"]);
            }
            if (oldGameList == null) { gameList.AddedDate = DateTime.Now; } else { gameList.EditedDate = DateTime.Now; gameList.AddedDate = oldGameList.AddedDate; }

            TempData["gameList"] = gameList;
            TempData["modelstate"] = ModelState;

             if (ModelState.IsValid)
            {

                if (oldGameList != null)
                {
                    _context.Set<GameList>().AddOrUpdate(gameList);
                }
                else
                {
                    _context.GameLists.Add(gameList);
                }
                _context.SaveChanges();

            }
            List<KeyValuePair<string, ModelState>> errors = new List<KeyValuePair<string, ModelState>>();
            foreach (var error in ModelState)
            {
                errors.Add(error);
            }
            TempData["errors"] = errors;
            ViewBag.userLists = userLists;

            if (Session["CurrentUrl"] == null) { return RedirectToAction("Details"); }*/
            return Redirect(null); //redirect to current url
        }

        private GameDetailsViewModel SetupDetailsPage(int id, GameList gamelist)
        {
            //get game
            var game = _gameService.FindActive(id);
            if (game == null) return null;

            //get reviews and articles for the game, set pagination
            var reviews = _context.GetGameReviewsList(game.Id);
            ViewBag.Pagination = new Pagination(null, null, reviews.Count());
            var articles = _context.GetArticlesList().Where(a => a.GameId == id).OrderByDescending(a => a.PublishedDate).Take(3);

            //get userlists for logged user for quick add to list form
            var userid = _userService.GetLoggedInUserId();
            var userLists = _context.UserLists.Where(u => u.UserId == userid).ToList();

            //setup stats if game is present on any user game list

            var gamesRankings = _gameService.GetUnorderedGamesRanking().OrderByDescending(o => o.Item2).ThenByDescending(d => d.Item1.ReleaseDate).ToList();

            int? position = gamesRankings.IndexOf(gamesRankings.Single(g => g.Item1.Id == id)) + 1;
            double? rating = gamesRankings.FirstOrDefault(g => g.Item1.Id == id).Item2;
            if (rating.HasValue) { rating = Math.Round(rating.Value, 1); } else { rating = 0; }

            var popularity = _context.GetGamesByPopularity().FindIndex(s => s.Item1.Id == id) + 1;

            var GameGameList = new GameAndGameListFormViewModel
            {
                Game = game,
                GameList = gamelist,
                userLists = userLists,
                Popularity = popularity,
                Ranking = position,
                Rating = rating
            };

            var reviewGametimes = setupReviewGametime(reviews);
            var viewModel = new GameDetailsViewModel
            {
                GameGameList = GameGameList,
                ReviewGametimes = reviewGametimes,
                RelevantArticles = articles
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
            return View(_context.GetFullGameForm(null));
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
            var newViewModel = _context.GetFullGameForm(null);
            newViewModel.Game = viewModel.Game;
            return View(newViewModel);
        }

        [HttpGet]
        [Route("games/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            var gameViewModel = _context.GetFullGameForm(id);

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
                //  if (Session["CurrentUrl"] == null) { return View(viewModel); }
                return Redirect(null);//return to saved url
            }
            var gameViewModel = _context.GetFullGameForm(viewModel.Game.Id);
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


            var games = _gameService.GetAllActive().OrderBy(s=>s.Title);
            var gamesRankings = _gameService.GetHighestRatedGames(null);
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
            var reviews = _context.GetGameReviewsList(game.Id);
           // Session["CurrentUrl"] = Request.Url.ToString();
            ViewBag.Pagination = new Pagination(page, items, reviews.Count());

            var model = SetupDetailsPage(id, null);

            return View(model);
        }

        public IEnumerable<ReviewGametimeViewModel> setupReviewGametime(IEnumerable<Review> reviews)
        {
            var reviewGametimes = new List<ReviewGametimeViewModel>();
            foreach (var rev in reviews)
            {
                var gamelist = _context.GameLists.Include(i => i.UserList).FirstOrDefault(f => f.GameId == rev.GameId && f.UserList.UserId == rev.UserId);
                int? playtime = null;
                if (gamelist != null) { playtime = gamelist.HoursPlayed; };

                var reviewGametime = new ReviewGametimeViewModel
                {
                    Review = rev,
                    Playtime = playtime
                };
                reviewGametimes.Add(reviewGametime);
            }
            return reviewGametimes;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("games/{id}/reviews/{review}")]
        public ActionResult SingleReview(int id, int? page, int? items, int review)
        {
            var game = _gameService.FindActive(id);
            if (game == null) return NotFound();
            var selectedReview = _context.GetReviewById(review);
            //Session["CurrentUrl"] = Request.Url.ToString();
            ViewBag.Pagination = new Pagination(page, items, 1);
            List < Review > Reviews = new List<Review>();
            Reviews.Add(selectedReview);
            var reviewGametimes = setupReviewGametime(Reviews);
            var model = SetupDetailsPage(id, null);
            model.ReviewGametimes = reviewGametimes;
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
    }
}