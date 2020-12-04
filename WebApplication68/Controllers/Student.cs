using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication68.Models;

namespace WebApplication68.Controllers
{
    public class Student : Controller
    {
        List<Students> l1 = new List<Students>
    {new Students{Sid=1,SName="Gaurav",SContact="9910374607",SDob="11/11/1998" },
            new Students{Sid=2,SName="ram",SContact="9910374607",SDob="11/11/1998" },
            new Students{Sid=3,SName="shyam",SContact="9910374607",SDob="11/11/1998" },
            new Students{Sid=4,SName="rajan",SContact="9910374607",SDob="11/11/1998" },
            new Students{Sid=5,SName="kiran",SContact="9910374607",SDob="11/11/1998" },

    };
        // GET: Student
        public ActionResult Display()
        {
            return View(l1);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
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

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
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

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
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
