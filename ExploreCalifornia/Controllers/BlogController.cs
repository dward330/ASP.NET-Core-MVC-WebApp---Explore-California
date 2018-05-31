using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExploreCalifornia.Controllers
{
    public class BlogController: Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var posts = new Post[] 
            {
                new Post
                {
                    Title = "DKW first Blog Post",
                    Posted = DateTime.Now,
                    Author = "Derrick Ward",
                    Body = "This is a wonderful blog post, don't you think?"
                },
                new Post
                {
                    Title = "DKW Second Blog Post",
                    Posted = DateTime.Now,
                    Author = "Kayla Ward",
                    Body = "Kayla's blog post is the best, don't you think?"
                }
        };

            return View(posts);
        }

        public IActionResult ContentResult()
        {
            return new ContentResult() { Content = "Welcome to the Blog Controller!" };
        }

        public IActionResult Post(string id)
        {
            var post = new Post
            {
                Title = "DKW Blog Post",
                Posted = DateTime.Now,
                Author = "Derrick Ward",
                Body = "This is a wonderful blog post, don't you think?"
            };

            return View(post);
        }
    }
}
