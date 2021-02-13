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
        private ITutorDAO _TutorDAO;

        public TutorService()
        {
            _TutorDAO = new TutorDAO();
        }



        public User GetUser(int id)
        {
            return _TutorDAO.GetUser(id);
        }


        public void AddUser(User user)
        {
            _TutorDAO.AddUser(user);
        }


        public void DeleteUser(User user)

        {
            _TutorDAO.DeleteUser(user);
        }



        public void EditUser(User user)
        {
            _TutorDAO.EditUser(user);
        }



        public List<User> GetUsers()
        {
            return _TutorDAO.GetUsers();
        }


        // Tutor CRUD Funct

        public Tutor GetTutor(int id)
        {

            return _TutorDAO.GetTutor(id);
        }

        public void AddTutor(Tutor tutor)
        {
            _TutorDAO.AddTutor(tutor);
        }


         public void DeleteTutor(Tutor tutor)
        {
            _TutorDAO.DeleteTutor(tutor);
        }

        public void EditTutor(Tutor tutor)
        {
            _TutorDAO.EditTutor(tutor);
        }

        public List<Tutor> GetTutors()
        {
            return _TutorDAO.GetTutors();
        }





    }
}