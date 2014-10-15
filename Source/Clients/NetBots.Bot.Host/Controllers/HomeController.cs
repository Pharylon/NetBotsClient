﻿using Newtonsoft.Json;
using GrahamBot;
using System.Web.Mvc;
using NetBots.Core;
using NetBots.Bot.Interface;

namespace NetBots.Bot.Host.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Index(MoveRequest moveRequest)
        {
            var moves = new Ai().GetMoves(moveRequest);
            return Json(moves);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
