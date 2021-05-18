using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PRO.Domain.Extensions;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;

using System.Linq;
using System.Web.Http.ModelBinding;

namespace PRO.UI.ViewComponents
{
    public class AddGameToUserListViewComponent : ViewComponent
    {
        private readonly IUserService _userService;
        private readonly IUserListService _userListService;
        private readonly IGameListService _gameListService;

        public AddGameToUserListViewComponent(
            IUserService userService,
            IGameListService gameListService,
            IUserListService userListService
            )
        {
            _userService = userService;
            _userListService = userListService;
            _gameListService = gameListService;
        }
        public IViewComponentResult Invoke(int gameid)
        {
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
                gameList = _gameListService.GetAll().SingleOrDefault(g => g.GameId == gameid && g.UserList.UserId == userid);
            }
            if (gameList == null) { gameList = new GameList(); }

            ViewBag.UserListId = userLists;
            //= new SelectList(userLists, "Id", "Name");
            ViewBag.GameId = gameid;
            ViewBag.Id = gameList.Id;

            return View("_AddGameToListForm", gameList);
        }

    }
}
