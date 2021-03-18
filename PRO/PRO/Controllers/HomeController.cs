using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PRO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using PRO.Domain.Interfaces.Services;
using PRO.Persistance.Data;

namespace PRO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGameService _gameService;

        public HomeController(ILogger<HomeController> logger, IGameService gameService)
        {
            _logger = logger;
            _gameService = gameService;
        }

        public IActionResult Index()
        {

            var test = _gameService.GetAll();
            var userId = User.GetLoggedInUserId<int>(); // Specify the type of your UserId;
            var userName = User.GetLoggedInUserName();
            //  var list =  test.Result;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
