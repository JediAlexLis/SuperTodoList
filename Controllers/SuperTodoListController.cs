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

        public async Task<IActionResult> Lists()
        {
            var lists = _context.ListsTodo.ToList();
            return View(lists);
        }

        public async Task<IActionResult> Actions()
        {
            var actions = _context.Actions.ToList();
            return View(actions);
        }
    }
}