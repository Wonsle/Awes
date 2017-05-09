using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Awes.Controllers
{
    public class TestController : Controller
    {
        
        public IActionResult Index()
        {
            new Employees().Register("Li", "KunLin", "N123456789", 0, new DateTime(1999, 9, 9));
            return View();
        }
    }
}
