using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StoreAPI.Controllers
{
    public class LineItemController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
