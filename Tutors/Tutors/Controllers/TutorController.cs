using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutors.Data;

namespace Tutors.Controllers
{
    public class TutorController : ApplicationController
    {
        // GET: Tutor
        public ActionResult Index()
        {
            return View("Index", _tutorService.GetTutors());
        }

        // GET: Tutor/Details/5
        public ActionResult Details(int id)
        {
            return View(_tutorService.GetTutor(id));
        }

        [HttpGet]
        // GET: Tutor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tutor/Create
        [HttpPost]
        public ActionResult Create(Tutor  t )
        {
            try
            {
                _tutorService.AddTutor(t);

                return RedirectToAction("Index");
            }
            catch    (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            return View();
        }

        // GET: Tutor/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_tutorService.GetTutor(id));
        }

        // POST: Tutor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Tutor tut)
        {
            try
            {
                _tutorService.EditTutor(tut);
                return RedirectToAction("Index", new { id = tut.TutorID, controller = "Tutor" });

                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
               
            }
            
        }

        // GET: Tutor/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_tutorService.GetTutor(id)); 
        }

        // POST: Tutor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Tutor tu)
        {
            try
            {
                tu = _tutorService.GetTutor(id);
                _tutorService.DeleteTutor(tu);
                return RedirectToAction("Index",new { controller = "Tutor", id = tu.TutorID });
   
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
                
            }
        }
    }
}
