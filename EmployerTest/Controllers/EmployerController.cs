using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployerTest.Models;

namespace EmployerTest.Controllers
{
    public class EmployerController : Controller
    {
        private EmployerRepository repository;

        public EmployerController()
        {
            repository = new EmployerRepository();
        }

        //
        // GET: /Employer/

        public ActionResult Index()
        {
            return View(repository.Employers);
        }

        //
        // GET: /Employer/Details/5

        public ActionResult Details(int id = 0)
        {
            Employer employer = repository.Employers.SingleOrDefault(e=>e.EmployerID == id);
            if (employer == null)
            {
                return HttpNotFound();
            }
            return View(employer);
        }

        //
        // GET: /Employer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employer/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employer employer)
        {
            if (ModelState.IsValid)
            {
                repository.AddEmployer(employer);
                return RedirectToAction("Index");
            }

            return View(employer);
        }

        //
        // GET: /Employer/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employer employer = repository.Employers.SingleOrDefault(e=>e.EmployerID == id);
            if (employer == null)
            {
                return HttpNotFound();
            }
            return View(employer);
        }

        //
        // POST: /Employer/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employer employer)
        {
            if (ModelState.IsValid)
            {
                repository.SaveEmployer(employer);
                return RedirectToAction("Index");
            }
            return View(employer);
        }

        //
        // GET: /Employer/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employer employer = repository.Employers.SingleOrDefault(e=>e.EmployerID == id);
            if (employer == null)
            {
                return HttpNotFound();
            }
            return View(employer);
        }

        //
        // POST: /Employer/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employer employer = repository.Employers.SingleOrDefault(e=>e.EmployerID == id);
            repository.RemoveEmployer(employer);
            return RedirectToAction("Index");
        }
    }
}