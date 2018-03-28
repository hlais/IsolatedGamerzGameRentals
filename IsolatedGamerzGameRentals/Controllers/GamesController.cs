using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//added librabray
using IsolatedGamerzGameRentals.Models;

namespace IsolatedGamerzGameRentals.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Random()
        {
            var game = new Game() { Name = "Super Mario World" };

            return View(game);
        }
    }
}