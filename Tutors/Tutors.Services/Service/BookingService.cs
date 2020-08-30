using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutors.Data;
using Tutors.Data.DAO;
using Tutors.Data.IDAO;
using Tutors.Services.IService;

namespace Tutors.Services.Service
{
    public class BookingService : IBookingService
    {
        private IBookingDAO _bookingDAO;
    
        public BookingService()
            {

            _bookingDAO = new BookingDAO();


            }


        public List<Booking> GetBookings()

        {

            return _bookingDAO.GetBookings();


        }

        public Booking GetBooking(int id)
        {

            return _bookingDAO.GetBooking(id);

        }

        public void EditBooking(Booking booking)
        {
            _bookingDAO.EditBooking(booking);

        }


        public void DeleteBooking(Booking booking)
        {
            _bookingDAO.DeleteBooking(booking);
        }



        public void AddBooking(Booking booking)
        {
            _bookingDAO.AddBooking(booking);



        }

        public User Booking(int id)
        {
           return _bookingDAO.Booking(id);
        }
    }
}
