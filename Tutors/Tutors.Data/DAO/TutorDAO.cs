using System.Collections.Generic;
using System.Linq;
using Tutors.Data.IDAO;
namespace Tutors.Data.DAO
{
    public class TutorDAO : ITutorDao
    {

        private TutorDatabaseContext _context;

        public TutorDAO()
        {
            _context = new TutorDatabaseContext();
        }

        public User GetTutor(int id)
        {
          
           var _user = from user
                     in _context.Users
                     where user.Id == id
                     select user;
            return _user.FirstOrDefault();

        }

        // add tutor
        public void AddTutor(User user)
        {
            user.Password = "123qwe";
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteTutor(User user)
        {
            
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void EditTutor(User user)
        {
            user.Password = "123qwe";
            _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
         
            _context.SaveChanges();
        }

        

        public List<User>GetTutors()
        {
            return _context.Users.ToList();
        }
    }
}
