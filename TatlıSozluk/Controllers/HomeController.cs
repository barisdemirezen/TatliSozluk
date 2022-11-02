using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TatliSozluk.Domain.Context;
using TatlıSozluk.Models;
using TatliSozluk.Service.PostServices;

namespace TatlıSozluk.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IPostService _postService;

        public HomeController(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<IActionResult> Index()
        {
            var trendingData = await _postService.GetAll();
            var lastPosts = await _postService.GetLastPosts();

            HomeViewModel model = new HomeViewModel
            {
                LastPosts = lastPosts,
                TrendingPosts = trendingData
            };

            return View(model);
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