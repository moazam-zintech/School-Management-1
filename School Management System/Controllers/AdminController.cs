using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace School_Management_System.Controllers
{
    public class AdminController : Controller
    {
        
        public IActionResult Admin()
        {
            return View();  
        }
    }
}
