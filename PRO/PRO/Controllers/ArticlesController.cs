using PRO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using PRO.ViewModels;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRO.Entities;
using PRO.Domain.Interfaces.Services;
/*
namespace PRO.Controllers
{

    public class ArticlesController : Controller
    {
        private readonly IArticleService _articleService;
        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [AllowAnonymous]
        [Route("articles/")]
        public ActionResult Index(int? page, int? items, string platform)
        {


            List<Article> articlesList = new List<Article>();
            List<Article> otherArticles = new List<Article>();
            if (platform == null || platform == "all")
            {
                articlesList = _context.GetArticlesList().Where(a=>a.IsActive == true).ToList();
            }
            else if (platform == "other")
            {
                otherArticles = _context.GetArticlesList().Where(a => a.IsActive == true).ToList(); ;
                articlesList = otherArticles
                .Where(i =>
                          !i.Game.Platform.Name.Contains("PC")
                        & !i.Game.Platform.Name.Contains("Playstation")
                        & !i.Game.Platform.Name.Contains("Xbox")
                        & !i.Game.Platform.Name.Contains("Switch"))
                .OrderByDescending(d=>d.PublishedDate)
                .ToList();

            }
            else
            {
                articlesList = _context.GetArticlesListByPlatform(platform);
            }

            ViewBag.Pagination = new Pagination(page, items, articlesList.Count());
            ViewBag.Platform = platform;
            return View(articlesList);
        }

        [Route("articles/manage")]
        [Authorize(Roles = "Admin,Author")]
        public ActionResult Manage(int? page, int? items)
        {
            List<Article> articlesList = null;

            if (!User.IsInRole("Admin"))
            {
                articlesList = _context.GetArticlesList().Where(s => s.Author.UserId == getCurrentUserId()).ToList();
            }
            else
            {
                articlesList = _context.GetArticlesList();
            }

            ViewBag.Pagination = new Pagination(page, items, articlesList.Count());
            return View(articlesList);
        }

        [AllowAnonymous]
        [Route("articles/{id}")]
        public ActionResult Details(int? id)
        {
            var article = _context.GetArticleById((int)id);
            var games = _context.GetGamesList().Where(a => a.ReleaseDate > DateTime.Now).OrderBy(a => a.ReleaseDate).Take(3).ToList();
            if (article == null)
            {
                return NotFound();
            }
            if(article.IsActive == false)
            {
                return NotFound();
            }
            var highestRatedGames = _context.GetUnorderedGamesRanking().OrderByDescending(o => o.Item2).Take(3).ToList();

            ArticleDetailsViewModel articleDetails = new ArticleDetailsViewModel
            {
                Article = article,
                RecentGames = games,
                RecentReviews = _context.GetRecentReviews(),
                BestRatedGames = highestRatedGames
            };
            return View(articleDetails);
        }


        [Route("articles/details/{id}")]
        [Authorize(Roles = "Admin,Author")]
        public ActionResult ManageDetails(int? id)
        {

            var article = _context.GetArticleById((int)id);
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

            return View(_context.GetFullArticleForm(null));
        }


        [HttpPost]
        [Route("articles/add")]
        [Authorize(Roles = "Admin,Author")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Article article)
        {
            if (ModelState.IsValid)
            {
                var userid = getCurrentUserId();
                if (userid == null)
                {
                    return RedirectToAction("Login", "Account");
                }
                if (_context.Authors.SingleOrDefault(s => s.UserId == (int)userid) == null)
                {
                    return NotFound();
                }
                article.UserId = (int)userid;
                article.PublishedDate = DateTime.Now;
                _context.Articles.Add(article);
                _context.SaveChanges();
                return RedirectToAction("Manage");
            }
            var articleViewModel = _context.GetFullArticleForm(null);
            articleViewModel.Article = article;
            return View(articleViewModel);
        }

        [Route("articles/edit/{id}")]
        [Authorize(Roles = "Admin,Author")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleViewModel articleViewModel = _context.GetFullArticleForm(id);
            if (articleViewModel.Article == null)
            {
                return HttpNotFound();
            }
            if (articleViewModel.Article.UserId != getCurrentUserId() && !User.IsInRole("Admin")) { RedirectToAction("Manage"); }

            return View(articleViewModel);
        }

        [HttpPost]
        [Route("articles/edit/{id}")]
        [Authorize(Roles = "Admin,Author")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ArticleViewModel articleViewModel)
        {
            if (articleViewModel.Article.UserId != getCurrentUserId() && !User.IsInRole("Admin")) { RedirectToAction("Manage"); }
            if (ModelState.IsValid)
            {
                _context.Entry(articleViewModel.Article).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Manage");
            }
            articleViewModel = _context.GetFullArticleForm(articleViewModel.Article.Id);
            return View(articleViewModel);
        }

        [Route("articles/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = _context.GetArticleById((int)id);
            if (article == null)
            {
                return HttpNotFound();
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
            Article article = _context.Articles.Find(id);
            _context.Articles.Remove(article);
            _context.SaveChanges();
            return RedirectToAction("Manage");
        }
        public int? getCurrentUserId()
        {
            string currentUserId = User.Identity.GetUserId();
            var user = _context.AppUsers.SingleOrDefault(s => s.UserId.Equals(currentUserId));
            if (user == null) return null;
            var id = user.Id;
            return id;
        }



        [AllowAnonymous]
        [Route("articles/search/{query?}")]
        public ActionResult Search(string query, int? page, int? items)
        {

            List<Article> articlesList = new List<Article>();
            List<Article> searchList = new List<Article>();

            articlesList = _context.GetArticlesList().Where(a => a.IsActive == true).ToList(); ;
            searchList = articlesList.Where(a =>
            a.Title.CaseInsensitiveContains(query) ||
            a.Preview.CaseInsensitiveContains(query) ||
            a.Content.CaseInsensitiveContains(query)
            ).ToList();
            
            ViewBag.Pagination = new Pagination(page, items, searchList.Count());
            ViewBag.Query = query;
            ViewBag.platform = "none";
            return View(searchList);
        }

    }
}*/