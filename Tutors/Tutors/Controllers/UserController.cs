using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutors.Data;




namespace Tutors.Controllers
{
    [Authorize]
    public class UserController : ApplicationController
    {
        [AllowAnonymous]
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

        // GET: Tutor/Create/add 
        
        public ActionResult Create()
        {

            return View();
        }

        // POST: Tutor/Create
        [HttpPost]
        public ActionResult Create( User user)
        {
            try
            {
                
               
                _tutorService.AddTutor(user);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return View();
        }

        // GET: Tutor/Edit/5
        [HttpGet]
        public ActionResult EditTutor (int id)
        {
            return View(_tutorService.GetTutor((id)));
        }

        // POST: Tutor/Edit/5
        [HttpPost]
        public ActionResult EditTutor (int id, User user)
        {
            try
            { 
                _tutorService.EditTutor(user);

                return RedirectToAction("Index", new{ id = user.Id,  controller = "User"});
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        // GET: Tutor/Delete/5
        public ActionResult DeleteTutor(int id)
        {
            return View(_tutorService.GetTutor((id)));
        }

        // POST: Tutor/Delete/5
        [HttpPost]
        public ActionResult DeleteTutor(User user)
        {
            try
            {
                User _Deletetutor;
                _Deletetutor = _tutorService.GetTutor(user.Id);
                _tutorService.DeleteTutor(_Deletetutor);
                 return RedirectToAction("Index",
                new {controller="User",id = _Deletetutor.Id});
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
