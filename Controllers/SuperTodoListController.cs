using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SuperTodoList.Controllers
{
    public class SuperTodoListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}