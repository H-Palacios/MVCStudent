using Microsoft.AspNetCore.Mvc;
using MVCStudent.Models;

namespace MVCStudent.Controllers
{
    public class ModuleController : Controller
    {
        ModuleContext db = new ModuleContext();
        public IActionResult Index()
        {
            return View(ModuleContext.moduleObjects);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Module temp)
        {
            Module data = temp;
            if (data.ModuleCode < 0 || data.Name == null || data.StaffId < 0 ||
                data.Hours < 0 || data.Venue == null)
            {
                ViewBag.Error = "Please don't be s.....";
                return View();
            }
            else
            {
                ModuleContext.moduleObjects.Add(data);
                return RedirectToAction("Index");
            }
        }
        public IActionResult Edit(int moduleCode)
        {
            Module temp = ModuleContext.moduleObjects.Where(x => x.ModuleCode == moduleCode).FirstOrDefault();
            return View(temp);
        }
        [HttpPost]
        public IActionResult Edit3(Module temp)
        {
            Module data = temp;
            if (data.ModuleCode < 0 || data.Name == null || data.StaffId < 0 ||
                data.Hours < 0 || data.Venue == null)
            {
                ViewBag.Error = "Please don't be s.....";
                return View();
            }
            else
            {
                (from p in ModuleContext.moduleObjects
                 where p.ModuleCode == data.ModuleCode
                 select p).ToList().ForEach(x =>
                 {
                     x.Name = data.Name;
                     x.StaffId = data.StaffId;
                     x.Hours = data.Hours;
                     x.Venue = data.Venue;
                 });
                return RedirectToAction("Index");
            }
        }

        public IActionResult Details(int moduleCode)
        {
            Module temp = ModuleContext.moduleObjects.Where(x => x.ModuleCode == moduleCode).FirstOrDefault();
            return View(temp);
        }
        public IActionResult Delete(int moduleCode)
        {
            Module temp = ModuleContext.moduleObjects.FirstOrDefault(s => s.ModuleCode == moduleCode);
            if (temp == null)
            {
                return NotFound();
            }
            return View(temp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int moduleCode)
        {
            Module temp = ModuleContext.moduleObjects.FirstOrDefault(s => s.ModuleCode == moduleCode);
            if (temp != null)
            {
                ModuleContext.moduleObjects.Remove(temp);
            }
            return RedirectToAction("Index");
        }
    }
}
