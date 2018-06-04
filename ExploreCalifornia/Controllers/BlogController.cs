using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.DAL;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExploreCalifornia.Controllers
{
    [Route("Blog")]
    public class BlogController: Controller
    {
        private readonly BlogDataContext _blogDataContext;

        public BlogController(BlogDataContext blogDataContext)
        {
            _blogDataContext = blogDataContext;
        }

        // GET: /<controller>/
        [Route("")]
        public IActionResult Index()
        {
            var posts = _blogDataContext.Posts.ToArray();

            return View(posts);
        }

        [Route("ContentResult")]
        public IActionResult ContentResult()
        {
            return new ContentResult() { Content = "Welcome to the Blog Controller!" };
        }

        [Route("ShowPost/{key?}")]
        public IActionResult ShowPost(string key)
        {
            var post = _blogDataContext.Posts.FirstOrDefault(x => string.Equals(x.key, key, StringComparison.CurrentCultureIgnoreCase));

            return View(post);
        }

        [HttpGet, Route("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("Create")]
        public IActionResult Create(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;

            _blogDataContext.Posts.Add(post);
            _blogDataContext.SaveChanges();

            return View("index", _blogDataContext.Posts.ToArray());
        }
    }
}
