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
            ApplicationUser user = _userService.FindActive(id);
            if (user == null)
            {
                return null;
            }
            var edituser = new EditUserViewModel
            {
                AppUser = user,
                Images = _imageService.GetAll().ToList()
            };
            UserProfileViewModel model = new UserProfileViewModel
            {
                EditUser = edituser,
                UserLists = _userListService.GetAll().ToList(),
                GameLists = _gameListService.GetAll().Where(u => u.UserList.UserId == user.Id).ToList(),
                ReviewsPlaytimes = _reviewService.UserPlaytimeList(user.Id),
                LoggedUserId = _userService.GetLoggedInUserId(),
                ListTypes = _listTypeService.GetAll().ToList(),
                RecentlyUpdatedGames = _gameListService.GetRecentUserGameListUpdates(user.Id, 3)
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
            { return RedirectToAction("Details","Users", new { id=id}); }

            int? loggeduserid = _userService.GetLoggedInUserId();
            if (loggeduserid == null) return NotFound();
            if (loggeduserid != id) return NotFound();
            ChangePasswordViewModel changePassword = new ChangePasswordViewModel
            {
                id = id
            };
            var edituser = new EditUserViewModel {
                AppUser = userdata,
                Images = _imageService.GetAll().ToList()
            };
            UserProfileViewModel model = new UserProfileViewModel
            {
                EditUser = edituser,
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
            var userProfile = UserProfileSetup(id);
            if (userProfile == null) return NotFound();
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

            var userprofile = UserProfileSetup(id);
            if (userprofile == null) return NotFound();


            return View(userprofile.EditUser);
        }

        [HttpPost]
        [Authorize]
        [Route("users/{id}/profile")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditProfileAsync(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.Update(model.AppUser);
                if (result.Succeeded)
                {
                    return RedirectToAction("Details", "Users", new { id = model.AppUser.Id });
                }
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
            ViewBag.Pagination = new Pagination(page, items, model.ReviewsPlaytimes.Count());

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