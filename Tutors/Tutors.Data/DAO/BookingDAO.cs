using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutors.Data.IDAO;
namespace Tutors.Data.DAO
{
    public class BookingDAO : IBookingDAO
    {
        private TutorDatabaseContext _context;

        public BookingDAO()

        {


            _context = new TutorDatabaseContext();


        }

        
        public List<Booking> GetBookings()
    {

       return _context.Bookings.ToList();


    }


    public Booking GetBooking(int id)
        {
            var _booking = from booking in _context.Bookings
                           where booking.BookingID == id
                           select booking;
                           return _booking.FirstOrDefault();
            
        }


        public void EditBooking(Booking booking)
        {
            _context.Entry(booking).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }



        public void DeleteBooking(Booking booking)
        {
            _context.Bookings.Remove(booking);
            _context.SaveChanges();
        }

        public void AddBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

        public User Booking (int id)
        {
            var _User = from users in _context.Users
                        where users.UserID == id
                        select users;
            return _User.FirstOrDefault();  

        }

    }






    

}