using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutors.Data;

namespace Tutors.Controllers
{
    public class UserViewModel
    {
        public int TutorId { get; set; }
    }
    public class SubjectController : ApplicationController
    {
        // GET: Subject
        public ActionResult Index()
        {
            return View("Index", _subjectService.GetSubjects());
        }

        // GET: Subject/Details/5
        public ActionResult Details(int id)
        {
            return View(_subjectService.GetSubject(id));
        }


        // GET: Subject/Create
        public ActionResult Create()
        {
            return View();
          
        }


        // POST: Subject/Create
        [HttpPost]
        public ActionResult Create(Subject subject)
        {
            try
            {

                _subjectService.AddSubject(subject);
                return RedirectToAction("Index");

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex);
                throw;

            }


        }
        [HttpGet]
        // GET: Subject/Edit/5
        public ActionResult Edit(int id)
        {

            ViewBag.Tutors = new SelectList(_subjectService.Users(), "UserID", "FirstName");
            return View(_subjectService.GetSubject(id));
        }

        // POST: Subject/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Subject subject)


        {
            try
            {

                // TODO: Add update logic here

                //ViewBag.Tutors = new SelectList(_subjectService.Users(), "UserID", "FirstName");
                //subject.SubjectID = ViewBag.Tutors;
                _subjectService.EditSubject(subject);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


      [HttpGet] 
        public ActionResult Delete(int id)
        {
            return View(_subjectService.GetSubject(id));
        }

        // POST: Subject/Delete/5
   [HttpPost]
        public ActionResult Delete(int id, Subject _subject)
        {
            try
            {
                // TODO: Add delete logic here

               _subject = _subjectService.GetSubject(id);
               _subjectService.DeleteSubject(_subject);
                return RedirectToAction("Index",
                new { controller = "Subject", id = _subject.SubjectID });
             

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        //Get Search Subjects Database 

        public ActionResult Search()
        {
            return View(_subjectService.SearchSubjects());

        }

        //Post Search Subject Database  

        [HttpPost]
        public ActionResult Search(string search)
        {
            return View(_subjectService.SearchSubjects(search));
        }
        



}
}

