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
        public ActionResult Indextwo()
        {
            return View("Indextwo", _subjectService.GetSubjects());
        }

        // GET: Subject/Details/5
        public ActionResult Detailstwo(int id)
        {
            return View(_subjectService.GetTutorViewModel(id));
        }


        // GET: Subject/Create
        public ActionResult Createtwo()
        {

            return View();

           
        }


        // POST: Subject/Create
        [HttpPost]
        public ActionResult Createtwo(Subject subject)
        {
            try
            {



                _subjectService.AddSubject(subject);
                return RedirectToAction("Indextwo");

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex);
                throw;

            }



        }



        // GET: Subject/Edit/5
        public ActionResult Edittwo(int id)
        {

            ViewBag.Tutors = new SelectList(_subjectService.Users(), "Id", "Name");
            return View(_subjectService.GetSubject(id));
        }

        // POST: Subject/Edit/5
        [HttpPost]
        public ActionResult Edittwo(int id, Subject subject)


        {
            try
            {

                // TODO: Add update logic here

                ViewBag.Tutors = new SelectList(_subjectService.Users(), "Id", "Name");
                subject.TutorId = ViewBag.Tutors;
                _subjectService.EditSubject(2);
                return RedirectToAction("Indextwo");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        // POST: Subject/Delete/5

        public ActionResult Deletetwo(int id)
        {
            try
            {
                // TODO: Add delete logic here


                Subject _Deletesubject;
                _Deletesubject = _subjectService.GetSubject(id);
                _subjectService.DeleteSubject(_Deletesubject);

                return RedirectToAction("Indextwo");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        //Get Search Subjects Database 

        public ActionResult SearchSubjects()
        {
            return View(_subjectService.SearchSubjects());

        }

        //Post Search Subject Database  

        [HttpPost]
        public ActionResult SearchSubjects(string search)
        {
            return View(_subjectService.SearchSubjects(search));
        }
        



}
}

