using LessionOnePartTwo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LessionOnePartTwo.Controllers
{
    public class HomeController : Controller
    {   
        public IActionResult Index()
        {
           DB db = new DB ();   

            return View(db.myc);
        }
    
    }
}