using Microsoft.AspNetCore.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class RegiController : Controller
    {
        [HttpGet]
        public IActionResult Regi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Regi(Data model)
        {
            if (ModelState.IsValid)
            {
                return View("Success", model);
            }
            else return View();

        }
        public IActionResult Succ(Data dane)
        {

            return View(dane);
        }
    }
}
