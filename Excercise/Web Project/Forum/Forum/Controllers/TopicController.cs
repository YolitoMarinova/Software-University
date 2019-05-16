using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Forum.Controllers
{
    public class TopicController : Controller
    {
        private readonly ForumDbContext context;

        public TopicController(ForumDbContext context)
        {
            this.context = context;
        }

        //GET: Topic/Details/id
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index","Home");
            }

            Topic topic = context.Topics
                .Include(t => t.Author)
                .Include(t=>t.Category)
                .Include(t=>t.Comments)
                .ThenInclude(c=>c.Author)
                .Where(t => t.Id == id)
                .SingleOrDefault();

            if (topic == null)
            {
                return RedirectToAction("Index","Home");
            }

            return View(topic);
        }

        public IActionResult Index()
        {
            return View();
        }

        //GET: Topic/Create
        [Authorize]
        public IActionResult Create()
        {
            var categoryNames = context.Categories.Select(c => c.Name).ToList();

            ViewData["CategoryNames"] = categoryNames;

            return View();
        }

        //POST: Topic/Create
        [HttpPost]
        [Authorize]
        public IActionResult Create(string categoryName,Topic topic)
        {
            if (ModelState.IsValid)
            {
                //Set CreatedDate and LastUpdatedDate
                topic.CreatedDate = DateTime.Now;
                topic.LastUpdatedDate = DateTime.Now;

                //Get User Id
                string authorId = context.Users
                    .Where(u => u.UserName == User.Identity.Name)
                    .First()
                    .Id;

                //Set topic Author Id
                topic.AuthorId = authorId;

                if (!context.Categories.Any(c => c.Name == categoryName))
                {
                    return View(topic);
                }

                int categoryId = context.Categories.SingleOrDefault(c => c.Name == categoryName).Id;

                topic.CategoryId = categoryId;

                //Save topic
                context.Topics.Add(topic);
                context.SaveChanges();

                return RedirectToAction("Index","Home");
            }

            return View(topic);
        }

        //GET: Topic/Delete/id
        [Authorize]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Ïndex","Home");
            }

            var topic = context.Topics
                .Include(t => t.Author)
                .SingleOrDefault(m => m.Id == id);

            if (topic == null)
            {
                return RedirectToAction("Index","Home");
            }

            if (topic.IsAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            return View(topic);
        }

        //POST: Topic/Delete/id
        [HttpPost]
        [Authorize]
        public IActionResult Delete(int id)
        {
            Topic topic = context.Topics
                .Include(t => t.Author)
                .SingleOrDefault(m => m.Id == id);

            if (topic != null)
            {
                //Delete topic
                context.Topics.Remove(topic);
                context.SaveChanges();
            }

            return RedirectToAction("Index","Home");
        }

        //GET: Topic/Edit/Id
        [Authorize]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index","Home");
            }

            Topic topic = context.Topics
                .Include(t => t.Author)
                .Include(t=>t.Category)
                .Where(t => t.Id == id)
                .SingleOrDefault();

            if (topic == null)
            {
                return RedirectToAction("Index","Home");
            }

            if (topic.IsAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            var categoryNames = context.Categories.Select(c => c.Name).ToList();

            ViewData["CategoryNames"] = categoryNames;

            return View(topic);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(string categoryName,Topic topic)
        {
            if (ModelState.IsValid)
            {
                Topic topicFromDb = context.Topics
                    .Include(t => t.Author)
                    .SingleOrDefault(t => t.Id.Equals(topic.Id));

                if (topicFromDb == null)
                {
                    return RedirectToAction("Index","Home");
                }

                topicFromDb.Description = topic.Description;
                topicFromDb.Title = topic.Title;

                int categoryId = context.Categories.SingleOrDefault(c => c.Name == categoryName).Id;
                topicFromDb.CategoryId = categoryId;

                topicFromDb.LastUpdatedDate = DateTime.Now;

                context.SaveChanges();

                return RedirectToAction("Index","Home");
            }

            return View(topic);
        }
    }
}