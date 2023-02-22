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

            return View("AddEdit", s);
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
            var Q1 = _context.Responses
                .Where(x => x.Quadrant == 1)
                .Where(x => x.Completed == false)
                .Include(x => x.Category)
                .ToList();

            var Q2 = _context.Responses
                .Where(x => x.Quadrant == 2)
                .Where(x => x.Completed == false)
                .Include(x => x.Category)
                .ToList();

            var Q3 = _context.Responses
                .Where(x => x.Quadrant == 3)
                .Where(x => x.Completed == false)
                .Include(x => x.Category)
                .ToList();

            var Q4 = _context.Responses
                .Where(x => x.Quadrant == 4)
                .Where(x => x.Completed == false)
                .Include(x => x.Category)
                .ToList();

            var model = new Quadrants
            {
                q1 = Q1,
                q2 = Q2,
                q3 = Q3,
                q4 = Q4,
            };

            return View(model);
        }
        
        
        
        //public IActionResult Quadrant()
        //{
        //    var q1 = _context.Responses.Include(x => x.Category).ToList();
        //    var q2 = _context.Responses.Include(x => x.Category).ToList();
        //    var q3 = _context.Responses.Include(x => x.Category).ToList();
        //    var q4 = _context.Responses.Include(x => x.Category).ToList();
        //    return View();
        //}
    }
}
