using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using WindowsFormsApp1;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]

            {
                new SelectListItem() { Value = "*", Text ="Умножить" },
                new SelectListItem() { Value = "+", Text ="Прибавить" },
                new SelectListItem() { Value = "-", Text ="Отнять" },
                new SelectListItem() { Value = "/", Text ="Разделить" },
                new SelectListItem() { Value = "^", Text ="Возвести в степень" },
                new SelectListItem() { Value = "e^", Text ="Проекспонентировать" }
            };
            return View();
        }


        [HttpPost]
        public ActionResult Index(
            float firstNumber,
            float secondNumber,
            string operation)
        {


            var calc = new Calc(); 
            float result = calc.Calculate(firstNumber, secondNumber, operation);

            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "*", Text ="Умножить" },
                new SelectListItem() { Value = "+", Text ="Прибавить" },
                new SelectListItem() { Value = "-", Text ="Отнять" },
                new SelectListItem() { Value = "/", Text ="Разделить" },
                new SelectListItem() { Value = "^", Text ="Возвести в степень" },
                new SelectListItem() { Value = "e^", Text ="Проекспонентировать" }
            };
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