using Microsoft.AspNetCore.Mvc;
using ridly.Data;
using ridly.Models;

namespace ridly.Controllers
{
    public class Category : Controller
    {
        private readonly Application_DB_Context _db;

        public Category(Application_DB_Context db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(category obj)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
