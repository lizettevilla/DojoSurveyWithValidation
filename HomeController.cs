using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SurveyValidation.Models;

namespace SurveyValidation.Controllers;

public class HomeController : Controller
{
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("result")]
        public IActionResult Result(SurveyResult newSurveyResult)
        {
            if (ModelState.IsValid)
            {
                return View("Result", newSurveyResult);
            }
            else
            {
                return View("Index");
            }
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
