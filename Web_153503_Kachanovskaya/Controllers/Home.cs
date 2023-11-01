using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web_153503_Kachanovskaya.Models;

namespace Web_153503_Kachanovskaya.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Лабораторная работа №2";

            var selectListDemo = new List<ListDemo>()
            {
                new(){ Id = 1, Name = "item 1"},
                new(){ Id = 2, Name = "item 2"},
                new(){ Id = 3, Name = "item 3"},
                new(){ Id = 4, Name = "item 4"},
                new(){ Id = 5, Name = "item 5"},
            };

            var selectList = new SelectList(selectListDemo, "Id", "Name");
            return View(selectList);
        }

        public IActionResult MenuPartial()
        {
            return PartialView("_MenuPartial");
        }

        public IActionResult UserInfoPartial()
        {
            return PartialView("_UserInfoPartial");
        }

    }
}
