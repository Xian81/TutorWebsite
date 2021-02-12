using System;
using System.Collections.Generic;
using Tutors.Data;
using Tutors.Data.IDAO;
using Tutors.Services.IService;
using Tutors.Data.DAO;


namespace Tutors.Services.Service
{
    public class TutorService : ITutorService
    {   
        private ITutorDao _TutorDao;

        public TutorService()
        {
            _TutorDao = new TutorDAO();
        }


        
        public User GetTutor(int id)
        {
            return _TutorDao.GetTutor(id);
        }

        
        public void AddTutor(User user)
        {
            _TutorDao.AddTutor(user);
        }

        
        public void DeleteTutor(User user)

        {
            _TutorDao.DeleteTutor(user);
        }

        

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