using System;
using Microsoft.AspNetCore.Mvc;

namespace squareRoot.Controllers
{
    public class squareRootController : Controller
    {
        [HttpGet]
        public ActionResult square()
        {
            return View();
        }

        [HttpPost]
        public ActionResult square(string firstNumber, string secondNumber)
        {
            

            int playerOne = int.Parse(firstNumber);
            int playerTwo = int.Parse(secondNumber);

            double sqr1 = Math.Sqrt(playerOne);
            double sqr2 = Math.Sqrt(playerTwo);

            double result1 = sqr1;
            double result2 = sqr2;

            ViewBag.Result1 = result1;
            ViewBag.Result2 = result2;
            return View();
        }
    }
    
}