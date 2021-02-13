using System.Collections.Generic;
using System.Linq;
using Tutors.Data.IDAO;



namespace Tutors.Data.DAO
{
    public class TutorDAO : ITutorDAO
    {

        private TutorDatabaseContext _context;

        public TutorDAO()
        {
            _context = new TutorDatabaseContext();
        }

        public User GetUser(int id)
        {
           var _user = from user
                     in _context.Users
                     where user.UserID == id
                     select user;
            return _user.FirstOrDefault();

        }

        // add tutor
        public void AddUser(User user)
        {
            user.Password = "123qwe";
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void EditUser(User user)
        {
            user.Password = "123qwe";
            _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        

        public List<User>GetUsers()
        {
            return _context.Users.ToList();
        }


        //Tutor table 

        public Tutor GetTutor (int id)
        {
            var _tutor = from tutor
                         in _context.Tutors
                         where tutor.TutorID == id
                         select tutor;
            return _tutor.FirstOrDefault();

        }



        public void AddTutor(Tutor tutor)
        {
            _context.Tutors.Add(tutor);
            _context.SaveChanges();

        }


        public void DeleteTutor (Tutor tutor)
        {
            _context.Tutors.Remove(tutor);
            _context.SaveChanges();
        }


        public void EditTutor(Tutor tutor)
        {
            _context.Entry(tutor).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }



        public List<Tutor> GetTutors()
        {
            return _context.Tutors.ToList();

        }

    }
}
