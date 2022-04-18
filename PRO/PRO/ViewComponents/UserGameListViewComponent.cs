using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Extensions;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System.Linq;

namespace PRO.UI.ViewComponents
{
    public class UserGameListViewComponent : ViewComponent
    {
        private readonly IUserService _userService;
        private readonly IUserListService _userListService;
        private readonly IGameListService _gameListService;
        private readonly IGameService _gameService;
        public UserGameListViewComponent(
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
        public IViewComponentResult Invoke(int userid, int? gamelistid)
        {
            var userLists = _userListService.GetUserUserLists(userid).ToList();

            var gameList = TempData.Get<GameList>("gameList");
           if (gameList != null && gamelistid.HasValue)
            {
                if (gameList.Id != gamelistid)
                {
                    gameList = null;
                }
            }

            if (gameList != null)
            {
                var errors = _gameListService.ValidateGameList(gameList);
                ModelState.Merge(errors);
            }


            if (gameList == null)
            {
                gameList = _gameListService.GetAll().SingleOrDefault(g => g.Id == gamelistid);
            }
            if (gameList == null) { 
                gameList = new GameList();
            }

            ViewBag.UserListId = userLists;
            ViewBag.Id = gameList.Id;
            ViewBag.Games = _gameService.GetAllActive();

            return View("_UserGameListForm", gameList);
        }

    }
}
