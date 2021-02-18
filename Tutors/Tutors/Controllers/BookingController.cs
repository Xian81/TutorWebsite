﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutors.Data;


namespace Tutors.Controllers
{
    [Authorize]
    public class BookingController : ApplicationController
    {
        // GET: Bookings
        public ActionResult Index()
        {
            return View("Index", _bookingService.GetBookings());
        }

        // GET: Bookings/Details/5
        public ActionResult Details(int id)
        {
            return View(_bookingService.GetBooking(id));
        }

        // GET: Bookings/Create
        public ActionResult Create()
        {
            ViewBag.Users = (new SelectList(_subjectService.Users(), "UserID", "UserID"));
            ViewBag.Tutors = (new SelectList(_tutorService.GetTutors(), "TutorID", "TutorID"));

            return View();
        }

        // POST: Bookings/Create
        [HttpPost]
        public ActionResult Create(Booking booking)
        {
            try
            {
                _bookingService.AddBooking(booking);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        // GET: Bookings/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Users = (new SelectList(_subjectService.Users(), "UserID", "UserID"));
            ViewBag.Tutors = (new SelectList(_tutorService.GetTutors(), "TutorID", "TutorID"));
            return View(_bookingService.GetBooking(id));
        }

        // POST: Bookings/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Booking booking)
        {
            try
            {
                // TODO: Add update logic here
                _bookingService.EditBooking(booking);
                return RedirectToAction("Index", new { id = booking.BookingID, controller = "Booking" });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        // GET: Bookings/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_bookingService.GetBooking((id)));
        }

        // POST: Bookings/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Booking booking)
        {
            try
            {
                // TODO: Add delete logic here
               booking = _bookingService.GetBooking(id);
                _bookingService.DeleteBooking(booking);
                return RedirectToAction("Index",
               new { controller = "Booking", id = booking.BookingID });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }


        }




    }
}