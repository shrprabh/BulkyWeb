using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            // Custom validation where the name and display order should not be same
            if (obj.Name != null && obj.Name.ToLower() == obj.DisplayOrder.ToString())
            {
                // the parameter is the key in form
                ModelState.AddModelError("name", "The Name Cannot Exactly Match the  Display order");
            }
            if (obj.Name!=null && obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Test in a Invalid Value");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                // after excecution where to redirect using RedirectToAction
                return RedirectToAction("Index");
            }
            // if its not valid stay in same page and display error message
            return View(obj);
        }
    }
}

