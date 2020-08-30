using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutors.Data;

namespace Tutors.Services.IService
{
    public interface IBookingService
    {

        List<Booking> GetBookings();

        Booking GetBooking(int id);

        void EditBooking(Booking booking);

        void DeleteBooking(Booking booking);

        void AddBooking(Booking booking);

        User Booking(int id);

    }
}
