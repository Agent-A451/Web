using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareWeb.Controllers
{
    public class SquareController : Controller
    {
        [HttpGet]
        public ActionResult Square()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Square(string firstNumber, string secondNumber)
        {
            ViewBag.firstNumber = firstNumber;
            ViewBag.secondNumber = secondNumber;

            int No1 = 0;
            bool isConverted1 = int.TryParse(firstNumber, out No1);

            int No2 = 0;
            bool isConverted2 = int.TryParse(secondNumber, out No2);

            int SQNo1 = (int)Math.Sqrt(No1);
            int SQNo2 = (int)Math.Sqrt(No2);

            ViewBag.SQNo1 = SQNo1;
            ViewBag.SQNo2 = SQNo2;

            ViewBag.isConverted1 = isConverted1;
            ViewBag.isConverted2 = isConverted2;

            ViewBag.No1 = No1;
            ViewBag.No2 = No2;
            return View();
        }
    }
}