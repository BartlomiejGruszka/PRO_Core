using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Extensions;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System.Linq;

namespace PRO.UI.ViewComponents
{
    public class UserListViewComponent : ViewComponent
    {
        private readonly IUserService _userService;
        private readonly IUserListService _userListService;
        private readonly IListTypeService _listTypeService;

        public UserListViewComponent(
            IUserService userService,
            IListTypeService listTypeService,
            IUserListService userListService
            )
        {
            _userService = userService;
            _userListService = userListService;
            _listTypeService = listTypeService;
        }
        public IViewComponentResult Invoke(int userid, int? listid)
        {
            if (!listid.HasValue) listid = 0;
            var userlist = TempData.Get<UserList>("userList");
            if (TempData["UserListId"] != null)
            {
                var userlistid = TempData["UserListId"] as int?;
                if (userlistid.HasValue)
                {
                    userlist.Id = userlistid.Value;
                }
            }

            if (userlist != null)
            {
                var errors = _userListService.ValidateUserList(userlist);
                ModelState.Merge(errors);
            }


            if (userlist == null)
            {
                userlist = _userListService.GetAll().SingleOrDefault(g => g.Id == listid && g.UserId == userid);
            }
            if (userlist == null) { userlist = new UserList(); }

            ViewBag.Id = userlist.Id;
            ViewBag.UserId = userid;
            ViewBag.listTypes = _listTypeService.GetAll();

            return View("_UserListForm", userlist);
        }

    }
}
