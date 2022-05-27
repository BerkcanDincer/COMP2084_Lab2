using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab2.Models;


namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        static List<Categories> categoriesList = new List<Categories>
        {
            new Categories() { Id = 1, Name = "Food"},
            new Categories() { Id = 2, Name = "Tech"},
            new Categories() { Id = 3, Name = "Sports"}
        };
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View(categoriesList);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            var selected = categoriesList.First<Categories>(x => x.Id == id);
            ViewBag.Message = "You selected category: " + selected.Name;
            return View(selected);
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
