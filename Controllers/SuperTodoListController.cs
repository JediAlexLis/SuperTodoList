using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperTodoList.Models;

namespace SuperTodoList.Controllers
{
    public class SuperTodoListController : Controller
    {
        private readonly SuperTodoListContext _context;

        public SuperTodoListController(SuperTodoListContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            return View();
        }

        public async Task<IActionResult> Structure()
        {
            return View();
        }

        public async Task<IActionResult> Ideas()
        {
            return View();
        }
    }
}