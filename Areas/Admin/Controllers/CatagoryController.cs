using Microsoft.AspNetCore.Mvc;
using mvc_project.Data;
using mvc_project.Models;
using System.Reflection.Metadata.Ecma335;

namespace mvc_project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CatagoryController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();


        public IActionResult Index()
        {
            var catagory = context.Catagories.ToList();
            return View(catagory);
        }
        public IActionResult Create()
        {
            return View(new Catagory());
        }
        public IActionResult Store(Catagory request)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", request);
            }
            context.Catagories.Add(request);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int id)
        {
            var catagory = context.Catagories.Find(id);
            if (catagory != null)
            {
                context.Catagories.Remove(catagory);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }


        }
        public IActionResult Edit(int id)
        {
            var catagory = context.Catagories.Find(id);
            if (catagory != null)
            {
                return View(catagory);
            }
            else {
                return RedirectToAction(nameof(Index));
            }
        }
        public IActionResult Update (Catagory req , int id){
            var catagory = context.Catagories.Update(req);
            context.SaveChanges();
            return RedirectToAction(nameof (Index));
        }
    }
}
