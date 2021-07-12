using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.HelperClasses;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using PRO.UI.ViewModels;

namespace PRO.Controllers
{

    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        private readonly IReviewService _reviewService;
        private readonly IImageService _imageService;
        private readonly IImageTypeService _imageTypeService;
        private readonly IUserListService _userListService;
        private readonly IGameListService _gameListService;
        private readonly IListTypeService _listTypeService;

        public UsersController
            (
            IUserService userService,
            IReviewService reviewService,
            IImageService imageService,
            IUserListService userListService,
            IGameListService gameListService,
            IListTypeService listTypeService,
            IImageTypeService imageTypeService
            )

        {
            _imageService = imageService;
            _userService = userService;
            _reviewService = reviewService;
            _userListService = userListService;
            _gameListService = gameListService;
            _listTypeService = listTypeService;
            _imageTypeService = imageTypeService;
        }

        [Authorize]
        [Route("users/userprofile")]
        public ActionResult UserProfile()
        {
            int? loggeduserid = _userService.GetLoggedInUserId();
            if (loggeduserid == null) { return NotFound(); }
            return RedirectToAction("Details", new { id = loggeduserid });
        }

        [Route("users/manage")]
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult Manage(string query, int? page, int? items, string sortOrder, string currentFilter)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["UserSortParm"] = String.IsNullOrEmpty(sortOrder) ? "user_desc" : "";
            ViewData["EmailSortParm"] = sortOrder == "email" ? "email_desc" : "email";
            ViewData["AddDateSortParm"] = sortOrder == "adddate" ? "adddate_desc" : "adddate";
            ViewData["EditDateSortParm"] = sortOrder == "editdate" ? "editdate_desc" : "editdate";

            if (!String.IsNullOrEmpty(query))
            {
                page = 1;
            }
            else
            {
                query = currentFilter;
            }
            ViewData["CurrentFilter"] = query;
            var users = _userService.FilterSearch(query);
            users = _userService.SortList(sortOrder, users);
            var result = PaginatedList<ApplicationUser>.Create(users.AsNoTracking(), page, items);

            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            result.Pagination.Action = action;
            return View(result);
        }

        [Route("users/{id}")]
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            ApplicationUser user = _userService.FindActive(id);
            if (user == null) { return NotFound(); }

            var playtimes = _reviewService.UserPlaytimeList(user.Id).AsQueryable();
            var gamelists = _gameListService.GetAll().Where(u => u.UserList.UserId == user.Id).ToList();
            UserProfileViewModel model = new UserProfileViewModel
            {
                AppUser = user,
                GameLists = gamelists.ToList(),
                ReviewsPlaytimes = PaginatedList<ReviewPlaytime>.Create(playtimes.AsNoTracking(), null, null),
                RecentlyUpdatedGames = _gameListService.GetRecentUserGameListUpdates(user.Id, 3),
                ListTypes = _listTypeService.GetAll().ToList()
            };
            model.ReviewsPlaytimes.Pagination.Action = "Details";
            ViewBag.IsOwner = _userService.IsOwner(id);

            return View(model);
        }

        [Route("users/details/{id}")]
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult ManageDetails(int? id)
        {
            ApplicationUser user = _userService.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [Route("users/add")]
        [Authorize(Roles = "Admin")]
        public ActionResult Add()
        {
            NewUserViewModel viewModel = new NewUserViewModel
            {
                Images = _imageService.GetAll().ToList(),
                ImageTypes = _imageTypeService.GetByType(ImageTypes.User)
            };
            return View(viewModel);
        }

        [Route("users/add")]
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Add(NewUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.AddUserAsync(model.AppUser, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Manage", "Users");
                }
                AddErrors(result);
            }
            model.Images = _imageService.GetAll().ToList();
            model.ImageTypes = _imageTypeService.GetByType(ImageTypes.User);
            return View(model);
        }

        [Route("users/edit/{id}")]
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult Edit(int? id)
        {

            ApplicationUser user = _userService.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            EditUserViewModel viewModel = new EditUserViewModel
            {
                AppUser = user,
                Images = _imageService.GetAll().ToList(),
                ImageTypes = _imageTypeService.GetByType(ImageTypes.User)
            };


            return View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Moderator")]
        [Route("users/edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.Update(model.AppUser);
                if (result.Succeeded)
                {
                    return RedirectToAction("Manage", "Users");
                }


            }
            model.Images = _imageService.GetAll().ToList();
            model.ImageTypes = _imageTypeService.GetAll();
            return View(model);
        }

        // GET: Authors/Delete/5
        [Route("users/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            ApplicationUser user = _userService.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Authors/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("users/delete/{id}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedAsync(int id)
        {
            ApplicationUser user = _userService.Find(id);

            //remove applicationUser
            var result = await _userService.Delete(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Manage", "Users");
            }


            //if failed 
            return View(user);
        }

        // GET: /Manage/ChangePassword
        [Authorize(Roles = "Admin")]
        [Route("users/changePassword/{id}")]
        public ActionResult ChangePassword(int id)
        {
            ChangePasswordViewModel viewModel = new ChangePasswordViewModel
            {
                Id = id
            };
            return View(viewModel);
        }

        //
        // POST: /Manage/ChangePassword
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [Route("users/changePassword/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(AdminChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var userdata = _userService.Find(model.id);
            if (userdata == null)
            { return RedirectToAction("Manage"); }

            IdentityResult passwordChangeResult = await _userService.ResetPasswordAsync(userdata, model.NewPassword);
            if (passwordChangeResult.Succeeded)
            {
                return RedirectToAction("Manage");

            }
            AddErrors(passwordChangeResult);
            return View(model);
        }


        [HttpGet]
        [Authorize]
        [Route("users/{id}/password")]
        public ActionResult UserChangePassword(int id)
        {
            var isOwner = _userService.IsOwner(id);
            if (!isOwner) { return NotFound(); };

            var userdata = _userService.Find(id);
            if (userdata == null)
            { return RedirectToAction("Details", "Users", new { id = id }); }

            ChangePasswordViewModel changePassword = new ChangePasswordViewModel
            {
                Id = id
            };
            ViewBag.AppUser = userdata;
            ViewBag.IsOwner = isOwner;
            return View(changePassword);
        }


        // change password function requiring old password for user
        [HttpPost]
        [Authorize]
        [Route("users/{id}/password")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UserChangePassword(ChangePasswordViewModel model, int id)
        {
            var isOwner = _userService.IsOwner(id);
            if (!isOwner) { return NotFound(); };

            var userdata = _userService.Find(id);
            if (userdata == null)
            { return RedirectToAction("Details", "Users", new { id = id }); }

            if (ModelState.IsValid)
            {
                var result = await _userService.ChangePasswordAsync(userdata, model.OldPassword, model.NewPassword);
                if (result.Succeeded)
                {
                    return RedirectToAction("Details", "Users", new { id = id });
                }
                AddErrors(result);
            }
            ChangePasswordViewModel changePassword = new ChangePasswordViewModel
            {
                Id = id
            };
            ViewBag.AppUser = userdata;
            ViewBag.IsOwner = isOwner;
            return View(changePassword);
        }

        [HttpGet]
        [Authorize]
        [Route("users/{id}/profile")]
        public ActionResult EditProfile(int? id)
        {
            var isOwner = _userService.IsOwner(id);
            if (!isOwner) { return NotFound(); };
            var user = _userService.Find(id);
            if (user == null) return NotFound();
            var model = new EditUserViewModel
            {
                AppUser = user
            };
            ViewBag.IsOwner = isOwner;
            return View(model);
        }

        [HttpPost]
        [Authorize]
        [Route("users/{id}/profile")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditProfileAsync(EditUserViewModel model)
        {
            var isOwner = _userService.IsOwner(model.AppUser.Id);
            if (!isOwner) { return NotFound(); };
            if (ModelState.IsValid)
            {
                ModelStateDictionary errors = new ModelStateDictionary();
                if (model.ImageFile != null)
                {
                    model.AppUser.ImageId = AddUserImage(model.ImageFile, model.AppUser);
                }

                if (ModelState.IsValid)
                {
                    var result = await _userService.Update(model.AppUser);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Details", "Users", new { id = model.AppUser.Id });
                    }
                }
            }
            model.Images = _imageService.GetAll().ToList();
            ViewBag.IsOwner = isOwner;
            return View(model);
        }

        private int? AddUserImage(IFormFile imagefile, ApplicationUser user)
        {
            var image = _imageService.CreateUserImage(imagefile, user.UserName);
            if (TryValidateModel(image))
            {
                _imageService.Add(image);
                var oldimage = _imageService.Find(user.ImageId);
                if (oldimage != null)
                {
                    _imageService.Delete(oldimage);
                }
                return image.Id;
            }
            return null;

        }

        [HttpGet]
        [AllowAnonymous]
        [Route("users/reviews/{id}")]
        public ActionResult Reviews(int? id, int? page, int? items)
        {
            var user = _userService.Find(id);
            if (user == null) { return NotFound(); }
            var playtimes = _reviewService.UserPlaytimeList(user.Id).AsQueryable();

            var model = new UserReviewsViewModel
            {
                AppUser = user,
                ReviewsPlaytimes = PaginatedList<ReviewPlaytime>.Create(playtimes.AsNoTracking(), page, items)
            };
            model.ReviewsPlaytimes.Pagination.Action = "Reviews";
            model.ReviewsPlaytimes.Pagination.RouteId = id;
            ViewBag.IsOwner = _userService.IsOwner(id);
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("users/gamelists/{id?}")]
        public ActionResult GameLists(int? id, int? page, int? items, string sortOrder, string currentFilter)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) ? "game_desc" : null;
            ViewData["NameSortParm"] = sortOrder == "Name" ? "Name_desc" : "Name";
            ViewData["ScoreSortParm"] = sortOrder == "score" ? "score_desc" : "score";
            ViewData["HoursSortParm"] = sortOrder == "hours" ? "hours_desc" : "hours";

            if (!id.HasValue) id = _userService.GetLoggedInUserId();
            var user = _userService.Find(id);
            if (user == null || !id.HasValue) { return NotFound(); }

            IQueryable<GameList> gamelists = _gameListService.OwnerGameLists(id);
            gamelists = _gameListService.FilterByList(currentFilter, gamelists);
            gamelists = _gameListService.SortList(sortOrder, gamelists);

            var model = new UserGameListsViewModel
            {
                AppUser = user,
                ListTypes = _listTypeService.GetAll().ToList(),
                GameLists = PaginatedList<GameList>.Create(gamelists.AsNoTracking(), page, items),
                LoggedUserId = user.Id
            };

            model.GameLists.Pagination.Action = "gamelists";
            model.GameLists.Pagination.RouteId = id;
            ViewData["CurrentFilter"] = currentFilter;
            ViewBag.IsOwner = _userService.IsOwner(id);
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("users/userlists/{id?}")]
        public ActionResult UserLists(int? id, int? page, int? items, string sortOrder, string currentFilter)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CountSortParm"] = sortOrder == "count" ? "count_desc" : "count";

            if (!id.HasValue) id = _userService.GetLoggedInUserId();
            var user = _userService.Find(id);
            if (user == null || !id.HasValue) { return NotFound(); }

            IQueryable<UserList> userlists = _userListService.OwnerUserLists(id);
            userlists = _userListService.FilterByList(currentFilter, userlists);
            userlists = _userListService.SortList(sortOrder, userlists);
            var model = new UserUserListsViewModel
            {
                AppUser = user,
                ListTypes = _listTypeService.GetAll().ToList(),
                UserLists = PaginatedList<UserList>.Create(userlists.AsNoTracking(), page, items),
                LoggedUserId = user.Id
            };

            model.UserLists.Pagination.Action = "userlists";
            model.UserLists.Pagination.RouteId = id;
            ViewData["CurrentFilter"] = currentFilter;
            ViewBag.IsOwner = _userService.IsOwner(id);
            return View(model);
        }

        [HttpGet]
        [Authorize]
        [Route("users/gamelist/{id?}")]
        public ActionResult GameListForm(int? id)
        {

            var userid = _userService.GetLoggedInUserId();
            var user = _userService.Find(userid);
            var gamelist = _gameListService.Find(id);
            var IsOwner = _userService.IsOwner(gamelist?.UserList?.UserId);
            if ((!IsOwner && gamelist != null) || user == null) { return NotFound(); }
            var model = new UserGameListFormViewModel
            {
                AppUser = user,
                GameList = gamelist
            };
            ViewBag.IsOwner = IsOwner;
            return View(model);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }

        [HttpGet]
        [Authorize]
        [Route("users/userlist/{id?}")]
        public ActionResult UserListForm(int? id)
        {

            var userid = _userService.GetLoggedInUserId();
            var user = _userService.Find(userid);
            var userlist = _userListService.Find(id);
            var IsOwner = _userService.IsOwner(userlist?.UserId);
            if ((!IsOwner && userlist != null) || user == null) { return NotFound(); }
            var model = new UserUserListFormViewModel
            {
                AppUser = user,
                UserList = userlist
            };
            ViewBag.IsOwner = IsOwner;
            return View(model);
        }
        [HttpGet]
        [Authorize]
        [Route("users/userlist/delete/{id}")]
        public ActionResult UserListDelete(int? id)
        {
            var userid = _userService.GetLoggedInUserId();
            var user = _userService.Find(userid);
            var userlist = _userListService.Find(id);
            var IsOwner = _userService.IsOwner(userlist.UserId);
            if (!IsOwner || user == null || userlist == null) { return NotFound(); }
            var model = new UserUserListFormViewModel
            {
                AppUser = user,
                UserList = userlist
            };
            ViewBag.IsOwner = IsOwner;
            return View(model);
        }
        [HttpGet]
        [Authorize]
        [Route("users/gamelist/delete/{id}")]
        public ActionResult GameListDelete(int? id)
        {
            var userid = _userService.GetLoggedInUserId();
            var user = _userService.Find(userid);
            var gamelist = _gameListService.Find(id);
            var IsOwner = _userService.IsOwner(gamelist?.UserList?.UserId);
            if (!IsOwner || user == null || gamelist == null) { return NotFound(); }
            var model = new UserGameListFormViewModel
            {
                AppUser = user,
                GameList = gamelist
            };
            ViewBag.IsOwner = IsOwner;
            return View(model);
        }
    }
}