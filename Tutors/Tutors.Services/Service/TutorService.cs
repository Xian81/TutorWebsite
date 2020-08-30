using System;
using System.Collections.Generic;
using Tutors.Data;
using Tutors.Data.IDAO;
using Tutors.Services.IService;
using Tutors.Data.DAO;


namespace Tutors.Services.Service
{
    public class TutorService : ITutorService
    {   //add
        //get
        //edit
        //delete
        private ITutorDao _TutorDao;

        public TutorService()
        {
            _TutorDao = new TutorDAO();
        }


        //get

        public User GetTutor(int id)
        {
            return _TutorDao.GetTutor(id);
        }

        // add

        public void AddTutor(User user)
        {
            _TutorDao.AddTutor(user);
        }

        //delete

        public void DeleteTutor(User user)

        {
            _TutorDao.DeleteTutor(user);
        }

        //edit

        public void EditTutor(User user)
        {
            _TutorDao.EditTutor(user);
        }


        // get tutor view model

        public List<User> GetTutors()
        {
            return _TutorDao.GetTutors();
        }

       
    }
}