using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Extensions;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using PRO.UI.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PRO.UI.ViewComponents
{
    public class AddGameToUserListViewComponent :ViewComponent
    {
        private readonly IGameService _gameService;
        private readonly IReviewService _reviewService;
        private readonly ICompanyService _companyService;
        private readonly IUserService _userService;
        private readonly IUserListService _userListService;
        private readonly IGameListService _gameListService;

        public AddGameToUserListViewComponent(
            IGameService gameService,
            IUserService userService,
            IReviewService reviewService,
            ICompanyService companyService,
            IGameListService gameListService,
            IUserListService userListService
            )
        {
            _gameService = gameService;
            _reviewService = reviewService;
            _companyService = companyService;
            _userService = userService;
            _userListService = userListService;
            _gameListService = gameListService;
        }
        public IViewComponentResult Invoke(int gameid)
        {
              var userid = _userService.GetLoggedInUserId();
              var userLists = _userListService.GetUserUserLists(userid).ToList();

            // var gameList = TempData["gameList"] as GameList;
            var gameList = TempData.Get<GameList>("gameList");

              if (gameList == null) { 
                gameList = _gameListService.GetAll().SingleOrDefault(g => g.GameId == gameid && g.UserList.UserId == userid); 
            }
              if (gameList == null) { gameList = new GameList(); }

              ViewBag.userLists = userLists;
              ViewBag.GameId = gameid;
            
            return View("_AddGameToListForm", gameList);
        }

    }
}
