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
                TempData["success"] = "Category created successfully";
                // after excecution where to redirect using RedirectToAction
                return RedirectToAction("Index");
            }
            // if its not valid stay in same page and display error message
            return View(obj);
        }
        public IActionResult Edit(int? categoryId)
            {
            if(categoryId == null || categoryId == 0)
                {
                    return NotFound();
                }
                Category? categoryFromDb = _db.Categories.Find(categoryId);
                //Category? categoryFromDb2 = _db.Categories.FirstOrDefault(u => u.CategoryId == categoryId);
                //Category? categoryFromDb3 = _db.Categories.Where(u => u.CategoryId == categoryId).FirstOrDefault();
            if (categoryFromDb==null)
                {
                    return NotFound();

                }
                return View(categoryFromDb);
            }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                // after excecution where to redirect using RedirectToAction
                TempData["success"] = "Category Updated successfully";
                return RedirectToAction("Index");
            }
            // if its not valid stay in same page and display error message
            return View(obj);
        }
        // used for retreiving the details
        public IActionResult Delete(int? categoryId)
        {
            if (categoryId == null || categoryId == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _db.Categories.Find(categoryId);
            //Category? categoryFromDb2 = _db.Categories.FirstOrDefault(u => u.CategoryId == categoryId);
            //Category? categoryFromDb3 = _db.Categories.Where(u => u.CategoryId == categoryId).FirstOrDefault();
            if (categoryFromDb == null)
            {
                return NotFound();

            }
            return View(categoryFromDb);
        }

        // since first and second action has same name we change the method name but the parameter will be same
        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePOST(int? categoryId)
        {
            Category obj = _db.Categories.Find(categoryId);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
}

