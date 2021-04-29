using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
            IListTypeService listTypeService
            )

        {
            _imageService = imageService;
            _userService = userService;
            _reviewService = reviewService;
            _userListService = userListService;
            _gameListService = gameListService;
            _listTypeService = listTypeService; 
        }

        //get userprofile
        [Authorize]
        [Route("users/userprofile")]
        public ActionResult UserProfile()
        {
            int? loggeduserid = _userService.GetLoggedInUserId();

            if (loggeduserid == null)
            {
                return NotFound();
            }
            return RedirectToAction("Details", new { id = loggeduserid });
        }

        // GET: Users
        [Route("users/manage")]
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult Manage(int? page, int? items)
        {

            var users = _userService.GetAll().ToList();

            ViewBag.Pagination = new Pagination(page, items, users.Count());
            return View(users);
        }

        [Route("users/{id}")]
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            var model = UserProfileSetup(id);
            if (model == null) { return NotFound(); }
            return View(model);
        }
        public UserProfileViewModel UserProfileSetup(int? id)
        {
            ApplicationUser user = _userService.Find(id);

            if (user == null)
            {
                return null;
            }
            List<GameList> gameLists = _gameListService.GetAll().Where(u => u.UserList.UserId == id).ToList();
            List<Review> reviews = _reviewService.GetUserReviews(user.Id);

            var tuplelist = new List<Tuple<GameList, DateTime>>();
            foreach (var gamelist in gameLists)
            {

                if (gamelist.EditedDate.HasValue)
                {
                    tuplelist.Add(new Tuple<GameList, DateTime>(gamelist, gamelist.EditedDate.Value));
                }
                else
                {
                    tuplelist.Add(new Tuple<GameList, DateTime>(gamelist, gamelist.AddedDate));
                }
            }
            var recentGames = tuplelist.OrderByDescending(o => o.Item2).Take(3).ToList();


            UserProfileViewModel model = new UserProfileViewModel
            {
                ApplicationUser = user,
                UserLists = _userListService.GetAll().ToList(),
                GameLists = gameLists,
                // Reviews = reviewGametimes,
                LoggedUserId = _userService.GetLoggedInUserId(),
                ListTypes = _listTypeService.GetAll().ToList(),
                RecentlyUpdatedGames = recentGames
            };
            return model;
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
                Images = _imageService.GetAll().ToList()
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
                var user = new ApplicationUser { UserName = model.UserName, Email = model.Email };
                var result = await _userService.AddUserAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //create normal user object
                    var userModel = new ApplicationUser
                    {
                        Id = user.Id,
                        RegisterDate = model.RegisterDate,
                        IsActive = model.IsActive,
                        IsPublic = model.IsPublic,
                        ImageId = model.ImageId,
                        Description = model.Description
                    };

                    return RedirectToAction("Manage", "Users");
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            model.Images = _imageService.GetAll().ToList();
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
                ImageId = user.ImageId,
                Images = _imageService.GetAll().ToList()
            };


            return View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Moderator")]
        [Route("users/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.Find(model.AppUser.Id);
                var appuser = user;

                appuser.Email = model.AppUser.Email;
                appuser.UserName = model.AppUser.UserName;

                user.RegisterDate = model.AppUser.RegisterDate;
                user.Description = model.AppUser.Description;
                user.IsActive = model.AppUser.IsActive;
                user.IsPublic = model.AppUser.IsPublic;
                user.ImageId = model.AppUser.ImageId;

                return RedirectToAction("Manage", "Users");

            }
            model.Images = _imageService.GetAll().ToList();
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
        public ActionResult DeleteConfirmed(int id)
        {
            ApplicationUser user = _userService.Find(id);

            //remove applicationUser
            return RedirectToAction("DeleteUser", "Manage", new { userId = user.Id });
        }

        // GET: /Manage/ChangePassword
        [Authorize(Roles = "Admin")]
        [Route("users/changePassword/{id}")]
        public ActionResult ChangePassword(int id)
        {
            ChangePasswordViewModel viewModel = new ChangePasswordViewModel
            {
                id = id
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

        // 
        [HttpGet]
        [Authorize]
        [Route("users/{id}/password")]
        public ActionResult UserChangePassword(int id)
        {
            var userdata = _userService.Find(id);
            if (userdata == null)
            { return RedirectToAction("Details"); }

            int? loggeduserid = _userService.GetLoggedInUserId();
            if (loggeduserid == null) return NotFound();
            if (loggeduserid != id) return NotFound();
            ChangePasswordViewModel changePassword = new ChangePasswordViewModel
            {
                id = id
            };
            UserProfileViewModel model = new UserProfileViewModel
            {
                ApplicationUser = userdata,
                LoggedUserId = loggeduserid,
                ChangePassword = changePassword
            };

            return View(model);
        }


        // change password function requiring old password for user
        [HttpPost]
        [Authorize]
        [Route("users/{id}/password")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UserChangePassword(ChangePasswordViewModel model, int id)
        {
            var userdata = _userService.Find(id);
            if (userdata == null)
            { return RedirectToAction("Details"); }

            int? loggeduserid = _userService.GetLoggedInUserId();
            if (loggeduserid == null) return NotFound();
            if (loggeduserid != id) return NotFound();

            ChangePasswordViewModel changePassword = new ChangePasswordViewModel
            {
                id = id
            };
            UserProfileViewModel userProfile = new UserProfileViewModel
            {
                ApplicationUser = userdata,
                LoggedUserId = loggeduserid,
                ChangePassword = changePassword
            };

            if (!ModelState.IsValid)
            {
                return View(userProfile);
            }
            var result = await _userService.ChangePasswordAsync(userdata, model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                return RedirectToAction("Details");
            }
            AddErrors(result);


            return View(userProfile);
        }


        [Route("users/{id}/lists")]
        [AllowAnonymous]
        public ActionResult UserGameList(int id)
        {

            return View();
        }

        [HttpGet]
        [Authorize]
        [Route("users/{id}/profile")]
        public ActionResult EditProfile(int? id)
        {
            ApplicationUser user = _userService.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            int? loggeduserid = _userService.GetLoggedInUserId();
            if (loggeduserid == null) return NotFound();
            if (loggeduserid != id) return NotFound();



            EditUserViewModel editViewModel = new EditUserViewModel
            {
                AppUser = user,
                ImageId = user.ImageId,
                Images = _imageService.GetAll().ToList()
            };

            UserProfileViewModel model = new UserProfileViewModel
            {
                ApplicationUser = user,
                LoggedUserId = loggeduserid,
                EditUser = editViewModel
            };


            return View(model);
        }

        [HttpPost]
        [Authorize]
        [Route("users/{id}/profile")]
        [ValidateAntiForgeryToken]
        public ActionResult EditProfile(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.Find(model.AppUser.Id);
                user.Email = model.AppUser.Email;
                user.UserName = model.AppUser.UserName;
                user.RegisterDate = model.AppUser.RegisterDate;
                user.Description = model.AppUser.Description;
                user.IsActive = model.AppUser.IsActive;
                user.IsPublic = model.AppUser.IsPublic;
                user.ImageId = model.ImageId;

                return RedirectToAction("Details", "Users", new { id = model.AppUser.Id });

            }
            model.Images = _imageService.GetAll().ToList();
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("users/{id}/reviews")]
        public ActionResult Reviews(int? id, int? page, int? items)
        {
            var model = UserProfileSetup(id);
            if (model == null) { return NotFound(); }
            ViewBag.Pagination = new Pagination(page, items, model.Reviews.Count());

            return View(model);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}