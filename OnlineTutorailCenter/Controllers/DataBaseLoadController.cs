using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTutorial.Data;


namespace OnlineTutorailCenter.Controllers
{
    public class DataBaseLoadController : Controller
    {
        private OnlineTutorialContext db = new OnlineTutorialContext();

        // GET: DataBaseLoad

        public ActionResult DBLoad()
        {
            // var students = db.Students.ToList();
            //return View(students);
            return view();
        }


        public ActionResult Index()
        {
            return View();
        }

        // GET: DataBaseLoad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DataBaseLoad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DataBaseLoad/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DataBaseLoad/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DataBaseLoad/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DataBaseLoad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DataBaseLoad/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
