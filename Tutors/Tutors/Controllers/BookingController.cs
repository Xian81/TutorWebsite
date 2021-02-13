using System;
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
                return RedirectToAction("Index", new { id = booking.BookingID, controller = "Bookings" });
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
                Booking _Deletebooking;
                _Deletebooking = _bookingService.GetBooking(booking.BookingID);
                _bookingService.DeleteBooking(_Deletebooking);
                return RedirectToAction("Index",
               new { controller = "Booking", id = _Deletebooking.BookingID });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }


        }




    }
}