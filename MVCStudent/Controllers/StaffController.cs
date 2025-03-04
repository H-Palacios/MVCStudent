using Microsoft.AspNetCore.Mvc;
using MVCStudent.Models;

namespace MVCStudent.Controllers
{
    public class StaffController : Controller
    {
        StaffContext db = new StaffContext();
        public IActionResult Index()
        {
            return View(StaffContext.staffObject);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Staff temp)
        {
            Staff data = temp;
            if (data.Id < 0 || data.Name == null || data.Pssword == null ||
                data.Dob == null || data.Title == null)
            {
                ViewBag.Error = "Please don't be s.....";
                return View();
            }
            else
            {
                StaffContext.staffObject.Add(data);
                return RedirectToAction("Index");
            }
        }
        public IActionResult Edit(int id)
        {
            Staff temp = StaffContext.staffObject.Where(x => x.Id == id).FirstOrDefault();
            return View(temp);
        }
        [HttpPost]
        public IActionResult Edit(Staff temp)
        {
            Staff data = temp;
            if (data.Id < 0 || data.Name == null || data.Pssword == null ||
                data.Dob == null || data.Title == null)
            {
                ViewBag.Error = "Please don't be s.....";
                return View();
            }
            else
            {
                (from p in StaffContext.staffObject
                 where p.Id == data.Id
                 select p).ToList().ForEach(x =>
                 {
                     x.Pssword = data.Pssword;
                     x.Dob = data.Dob;
                     x.Title = data.Title;
                     x.Name = data.Name;
                 });
                return RedirectToAction("Index");
            }
        }

        public IActionResult Details(int id)
        {
            Staff temp = StaffContext.staffObject.Where(x => x.Id == id).FirstOrDefault();
            return View(temp);
        }
        // GET: Staff/Delete/5 (Displays the confirmation view)
        public IActionResult Delete(int id)
        {
            Staff temp = StaffContext.staffObject.FirstOrDefault(s => s.Id == id);
            if (temp == null)
            {
                return NotFound();
            }
            return View(temp);
        }

        // POST: Staff/Delete/5 (Deletes the staff member)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Staff temp = StaffContext.staffObject.FirstOrDefault(s => s.Id == id);
            if (temp != null)
            {
                StaffContext.staffObject.Remove(temp);
            }
            return RedirectToAction("Index");
        }
    }
}
