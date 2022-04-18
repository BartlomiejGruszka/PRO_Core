using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Extensions;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System.Linq;

namespace PRO.UI.ViewComponents
{
    public class AddGameToUserListViewComponent : ViewComponent
    {
        private readonly IUserService _userService;
        private readonly IUserListService _userListService;
        private readonly IGameListService _gameListService;
        private readonly IGameService _gameService;
        public AddGameToUserListViewComponent(
            IUserService userService,
            IGameListService gameListService,
            IUserListService userListService,
            IGameService gameService
            )
        {
            _userService = userService;
            _userListService = userListService;
            _gameListService = gameListService;
            _gameService = gameService;
        }
        public IViewComponentResult Invoke(int? gameid)
        {
            if (!gameid.HasValue) gameid = 0;
            var userid = _userService.GetLoggedInUserId();
            var userLists = _userListService.GetUserUserLists(userid).ToList();

            var gameList = TempData.Get<GameList>("gameList");
            if (TempData["GameListId"] != null)
            {
                var gamelistid = TempData["GameListId"] as int?;
                if (gamelistid.HasValue)
                {
                    gameList.Id = gamelistid.Value;
                }
            }

            if (gameList != null)
            {
                var errors = _gameListService.ValidateGameList(gameList);
                ModelState.Merge(errors);
            }


            if (gameList == null)
            {
                gameList = _gameListService.GetAll().FirstOrDefault(g => g.GameId == gameid && g.UserList.UserId == userid);
            }
            if (gameList == null)
            {
                gameList = new GameList();
            }

            ViewBag.UserListId = userLists;
            ViewBag.GameId = gameid;
            ViewBag.Id = gameList.Id;

            return View("_AddGameToUserList", gameList);
        }

    }
}
