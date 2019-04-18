using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LoginReg.Controllers
{
    public class DashboardController : Controller
    {
        private LoginRegContext dbContext;

        public DashboardController(LoginRegContext context)
        {
            dbContext = context;
        }

        [Route("dashboard")]
        [HttpGet]
        public IActionResult Dashboard()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Index", "Home");
            ViewBag.User = dbContext.Users.FirstOrDefault(u => u.UserId == userId);
            var ModelWrapper = new ModelWrapper
            {
                Messages = dbContext.Messages
                .OrderByDescending(m => m.CreatedAt)
                .Include(message => message.User)
                .ToList(),
                Comments = dbContext.Comments
                .Include(c => c.User)
                .ToList()
            };

            return View("Dashboard", ModelWrapper);
        }

        [Route("add/message")]
        [HttpPost]
        public IActionResult AddMessage(Message newMessage)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Index", "Home");

            if (ModelState.IsValid)
            {
                newMessage.UserId = (int)userId;
                dbContext.Add(newMessage);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return View("Dashboard");
        }
        [Route("add/comment")]
        [HttpPost]
        public IActionResult AddComment(ModelWrapper newModelWrapper)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("Index", "Home");

            if (ModelState.IsValid)
            {
                newModelWrapper.Comment.UserId = (int)userId;
                dbContext.Add(newModelWrapper.Comment);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            Console.WriteLine("Not Valid!");
            return RedirectToAction("Dashboard");
        }
    }
}
