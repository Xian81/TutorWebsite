using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutors.Services.IService;
using Tutors.Services.Service;

namespace Tutors.Controllers
{
    public abstract class  ApplicationController : Controller
    {
        public TutorService _tutorService;
        public SubjectService _subjectService;
        public BookingService _bookingService;
       

        public ApplicationController()
        {
            _tutorService = new TutorService();
            _subjectService = new SubjectService();
            _bookingService = new BookingService();
           
        }
    }
}