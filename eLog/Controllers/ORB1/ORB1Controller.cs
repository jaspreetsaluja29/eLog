using Microsoft.AspNetCore.Mvc;

namespace eLog.Controllers.ORB1
{
    public class ORB1Controller : Controller
    {
        public IActionResult CodeA()
        {
            return RedirectToAction("GetCodeAData", "CodeA");
        }

        public IActionResult CodeB()
        {
            return View();
        }

        public IActionResult CodeC()
        {
            return View();
        }
    }
}
