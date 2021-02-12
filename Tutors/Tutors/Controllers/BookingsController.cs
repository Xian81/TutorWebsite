using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutors.Data;


namespace Tutors.Controllers
{
    [Authorize]
    public class BookingsController : ApplicationController
    {
        // GET: Bookings
        public ActionResult Indexthree()
        {
            return View("Indexthree", _bookingService.GetBookings());
        }

        // GET: Bookings/Details/5
        public ActionResult Detailsthree(int id)
        {
            return View(_bookingService.GetBooking(id));
        }

        // GET: Bookings/Create
        public ActionResult Createthree()
        {
            return View();
        }

        // POST: Bookings/Create
        [HttpPost]
        public ActionResult Createthree(Booking booking)
        {
            try
            {


                _bookingService.AddBooking(booking);

                return RedirectToAction("Indexthree");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        // GET: Bookings/Edit/5
        public ActionResult Editthree(int id)
        {
            return View(_bookingService.GetBooking(id));
        }

        // POST: Bookings/Edit/5
        [HttpPost]
        public ActionResult Editthree(int id, Booking booking)
        {
            try
            {
                // TODO: Add update logic here
                _bookingService.EditBooking(booking);
                return RedirectToAction("Indexthree", new { id = booking.BookingID, controller = "Bookings" });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        // GET: Bookings/Delete/5
        public ActionResult Deletethree(int id)
        {
            return View(_bookingService.GetBooking((id)));
        }

        // POST: Bookings/Delete/5
        [HttpPost]
        public ActionResult Deletethree(int id, Booking booking)
        {
            try
            {
                // TODO: Add delete logic here
                Booking _Deletebooking;
                _Deletebooking = _bookingService.GetBooking(booking.BookingID);
                _bookingService.DeleteBooking(_Deletebooking);
                return RedirectToAction("Indexthree",
               new { controller = "Bookings", id = _Deletebooking.BookingID });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }


        }

        // Get Booking Tutor Details 
        public ActionResult Details(int id)
        {
            return View(_bookingService.Booking(id));


        }




    }
}