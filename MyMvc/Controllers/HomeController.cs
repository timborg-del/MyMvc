using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MyMvc.Models;

namespace MyMvc.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Info()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }        
        public IActionResult CheckFever()
        {
            return View();
        }
        public IActionResult NumberGuessing()
        {
            HttpContext.Session.SetInt32("numberToGuess", new Random().Next(1, 101));
            return View();
        }
        [HttpPost]
        public IActionResult CheckFever(int Temp)
        {
           string result = FeverCheck.Fever(Temp);
            ViewBag.CheckFever = result;
            return View();
        } 
        [HttpPost]
        public IActionResult NumberGuessing(int Number)
        {
            int randomNumber = (int)HttpContext.Session.GetInt32("numberToGuess");
            string result = GuessedNumber.Numbers(Number, randomNumber);
            ViewBag.NumberGuessing = result;
            return View(); 
        }

    }
}
