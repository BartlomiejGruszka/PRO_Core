﻿using PRO.Models;
using PRO.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*
namespace PRO.Controllers
{
    [Authorize(Roles = "Admin,Author")]
    public class GamesController : Controller
    {
        private GameRepository _gameRepository;
        private ApplicationDbContext _context;
        public GamesController()
        {
            this._gameRepository = new GameRepository(new ApplicationDbContext());
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        [AllowAnonymous]
        [Route("games/")]
        public ActionResult Index()
        {
            var pageString = Request.QueryString["page"];
            var itemString = Request.QueryString["items"];


            var games = _context.GetGamesList().Where(g => g.IsActive == true).OrderBy(g => g.Title).ToList();
            var gamescores = _context.GetUnorderedGamesRanking().OrderBy(g => g.Item1.Title);
            var viewModel = new GameFilterViewModel
            {
                Games = games,
                GameScores = gamescores
            };
            ViewBag.Pagination = new Pagination(pageString, itemString, games.Count());
            return View(viewModel);
        }

        [HttpGet]
        [Route("games/manage")]
        public ActionResult Manage()
        {
            var pageString = Request.QueryString["page"];
            var itemString = Request.QueryString["items"];

            var games = _context.GetGamesList();

            ViewBag.Pagination = new Pagination(pageString, itemString, games.Count());
            return View(games);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("games/{id}")]
        public ActionResult Details(int id)
        {
            var viewModel = setupDetailsPage(id, null);
            Session["CurrentUrl"] = Request.Url.ToString();
            return View(viewModel);
        }

        [ChildActionOnly]
        [HttpGet]
        public ActionResult AddGameToList(int id)
        {

            var userid = getCurrentUserId();
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

            return PartialView("_AddGameToListForm", gameList);
        }


        [HttpPost]
        public ActionResult AddGameToList(int id, [Bind(Include = "Id,HoursPlayed,PersonalScore,UserListId,GameId")] GameList gameList)
        {

            var userid = getCurrentUserId();
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

            if (Session["CurrentUrl"] == null) { return RedirectToAction("Details"); }
            return Redirect((string)Session["CurrentUrl"]);
        }

        private GameDetailsViewModel setupDetailsPage(int id, GameList gamelist)
        {
            //get game
            var game2 = _context.GetGameById(id);
            var game = _gameRepository.Find(id);
            if (game == null) return null;
            if (game.IsActive == false) return null;

            //get reviews and articles for the game, set pagination
            var reviews = _context.GetGameReviewsList(game.Id);
            ViewBag.Pagination = new Pagination(null, null, reviews.Count());
            var articles = _context.GetArticlesList().Where(a => a.GameId == id).OrderByDescending(a => a.PublishedDate).Take(3);

            //get userlists for logged user for quick add to list form
            var userid = getCurrentUserId();
            var userLists = _context.UserLists.Where(u => u.UserId == userid).ToList();

            //setup stats if game is present on any user game list

            var gamesRankings = _context.GetUnorderedGamesRanking().OrderByDescending(o => o.Item2).ThenByDescending(d => d.Item1.ReleaseDate).ToList();

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
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game games = _context.GetGameById((int)id);
            if (games == null)
            {
                return HttpNotFound();
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
            var languages = _context.Languages.ToList();
            var tags = _context.Tags.ToList();
            if (viewModel.selectedTagsId != null)
            {
                foreach (var tagid in viewModel.selectedTagsId)
                {
                    viewModel.Game.Tags.Add(tags.Single(s => s.Id == tagid));
                }
            }
            if (viewModel.selectedLanguagesId != null)
            {
                foreach (var languageid in viewModel.selectedLanguagesId)
                {
                    viewModel.Game.Languages.Add(languages.Single(s => s.Id == languageid));
                }
            }

            if (ModelState.IsValid)
            {

                _context.Games.Add(viewModel.Game);
                _context.SaveChanges();
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
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var gameViewModel = _context.GetFullGameForm(id);

            if (gameViewModel.Game == null) return HttpNotFound();

            return View(gameViewModel);

        }

        [HttpPost]
        [Route("games/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GameViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                var languages = _context.Languages.ToList();
                var tags = _context.Tags.ToList();
                var newLanguages = new List<Language>();
                var newTags = new List<Tag>();

                _context.Entry(viewModel.Game).State = EntityState.Modified;



                if (viewModel.selectedTagsId != null)
                {
                    _context.Entry(viewModel.Game).Collection(l => l.Tags).Load();
                    viewModel.Game.Tags.Clear();

                    foreach (var tagid in viewModel.selectedTagsId)
                    {
                        viewModel.Game.Tags.Add(tags.Single(s => s.Id == tagid));
                    }
                }
                if (viewModel.selectedLanguagesId != null)
                {
                    _context.Entry(viewModel.Game).Collection(l => l.Languages).Load();
                    viewModel.Game.Languages.Clear();

                    foreach (var languageid in viewModel.selectedLanguagesId)
                    {
                        viewModel.Game.Languages.Add(languages.Single(s => s.Id == languageid));
                    }
                }

                _context.SaveChanges();
                if (Session["CurrentUrl"] == null) { return View(viewModel); }
                return Redirect((string)Session["CurrentUrl"]);
                // return RedirectToAction("Manage");
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
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = _context.GetGameById((int)id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        [Route("games/delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Game game = _context.GetGameById((int)id);
            _context.Games.Remove(game);
            _context.SaveChanges();
            return RedirectToAction("Manage");
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("games/ranking")]
        public ActionResult Ranking()
        {
            var pageString = Request.QueryString["page"];
            var itemString = Request.QueryString["items"];


            var games = _context.GetGamesList().Where(g => g.IsActive == true).OrderBy(g => g.Title).ToList();
            var gamesRankings = _context.GetUnorderedGamesRanking().OrderByDescending(o => o.Item2).ThenByDescending(d => d.Item1.ReleaseDate).ToList();
            var viewModel = new GameFilterViewModel
            {
                Games = games,
                GameScores = gamesRankings
            };
            ViewBag.Pagination = new Pagination(pageString, itemString, games.Count());
            return View(viewModel);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("games/{id}/reviews")]
        public ActionResult Reviews(int id)
        {
            var game = _context.GetGameById(id);
            if (game == null) return HttpNotFound();
            if (game.IsActive == false) { return HttpNotFound(); }
            var reviews = _context.GetGameReviewsList(game.Id);
            var pageString = Request.QueryString["page"];
            var itemString = Request.QueryString["items"];
            Session["CurrentUrl"] = Request.Url.ToString();
            ViewBag.Pagination = new Pagination(pageString, itemString, reviews.Count());


            var model = setupDetailsPage(id, null);

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
        public ActionResult SingleReview(int id, int review)
        {
            var game = _context.GetGameById(id);
            if (game == null) return HttpNotFound();
            var selectedReview = _context.GetReviewById(review);
            var pageString = Request.QueryString["page"];
            var itemString = Request.QueryString["items"];
            Session["CurrentUrl"] = Request.Url.ToString();
            ViewBag.Pagination = new Pagination(pageString, itemString, 1);
            List < Review > Reviews = new List<Review>();
            Reviews.Add(selectedReview);
            var reviewGametimes = setupReviewGametime(Reviews);
            var model = setupDetailsPage(id, null);
            model.ReviewGametimes = reviewGametimes;
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("games/search/{query?}")]
        public ActionResult Search(string query)
        {
            var pageString = Request.QueryString["page"];
            var itemString = Request.QueryString["items"];


            var games = _context.GetGamesList().ToList();
            var filteredgames = games
                .Where(g =>
                g.Title.CaseInsensitiveContains(query) ||
                g.Description.CaseInsensitiveContains(query) ||
                g.DeveloperCompany.Name.CaseInsensitiveContains(query) ||
                g.PublisherCompany.Name.CaseInsensitiveContains(query) ||
                g.Status.Name.CaseInsensitiveContains(query)
                ).ToList();

            var viewModel = new GameFilterViewModel
            {
                Games = filteredgames,
                GameScores = _context.GetUnorderedGamesRanking().OrderBy(g => g.Item1.Title)
            };
            ViewBag.Pagination = new Pagination(pageString, itemString, filteredgames.Count());
            return View("Index", viewModel);
        }
        public int? getCurrentUserId()
        {
            string currentUserId = User.Identity.GetUserId();
            var user = _context.AppUsers.SingleOrDefault(s => s.UserId.Equals(currentUserId));
            if (user == null) return null;
            var id = user.Id;
            return id;
        }
    }
}*/