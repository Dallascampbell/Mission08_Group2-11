using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission08_Group2_11.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission08_Group2_11.Controllers
{
    public class HomeController : Controller
    {

        private SubmitTaskContext _context { get; set; }

        public HomeController(SubmitTaskContext x)
        {
            _context = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddEdit()
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddEdit(SubmitTask s)
        {
            _context.Add(s);
            _context.SaveChanges();

            return View(s);
        }

        [HttpGet]
        public IActionResult Edit(int taskId)
        {
            ViewBag.Categories = _context.Categories.ToList();

            var submitTask = _context.Responses.Single(x => x.TaskID == taskId);

            return View("AddEdit", submitTask);
        }

        [HttpPost]
        public IActionResult Edit(SubmitTask s)
        {
            _context.Update(s);
            _context.SaveChanges();
            return RedirectToAction("Quadrant");
        }

        [HttpGet]
        public IActionResult Delete(int taskId)
        {
            var submitTask = _context.Responses.Single(x => x.TaskID == taskId);
            return View(submitTask);
        }

        [HttpPost]
        public IActionResult Delete(SubmitTask s)
        {
            _context.Responses.Remove(s);
            _context.SaveChanges();
            return RedirectToAction("Quadrant");
        }

        public IActionResult Quadrant()
        {
            
            var currentTasks = _context.Responses
                .Where(x => !x.Completed)
                .Include(x => x.Category)
                .ToList();

            return View(currentTasks);
        }
        
        
    }
}
