using System.Collections.Generic;
using System.Linq;
using Tutors.Data.IDAO;
using Tutors.Data.View_Model;

namespace Tutors.Data.DAO

{
    public class SubjectDAO : ISubjectDAO 

    {
        private TutorDatabaseContext _context;



        public SubjectDAO()
        {

            _context = new TutorDatabaseContext();

        }

        public List<User> Users()
        {
            return _context.Users.Where(x => x.RoleID == 2).ToList();
        }

        public List<Subject> GetSubjects()
        {
            return _context.Subjects.ToList();
        }

        public Subject GetSubject(int id)
        {

            var _subject = from subject
                           in _context.Subjects
                           where subject.SubjectID == id
                           select subject;
            return _subject.FirstOrDefault();
        }

        public void EditSubject(Subject subj)
        {
            _context.Entry(subj).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteSubject(Subject subject)
        {
            _context.Subjects.Remove(subject);
            _context.SaveChanges();
        }

        public void AddSubject(Subject subject)
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();
        }

        public TutorViewModel GetTutorViewModel(int id)
        {

            IQueryable<TutorViewModel> _tutorviewmodel = from tutor in _context.Tutors
                                                         from subject in _context.Subjects
                                                         from user in _context.Users
                                                         from age in _context.AgeRanges
                                                         from role in _context.Roles
                                                         where tutor.TutorID == id
                                                         && subject.SubjectID == user.UserID
                                                         select new TutorViewModel
                                                         {
                                                             TutorID = tutor.TutorID,
                                                             Location = tutor.TutorLocation,
                                                             FirstName = user.FirstName,
                                                             Address = user.Address,
                                                             Role = role.RoleName,
                                                             Username = user.UserName,
                                                             SubjectName = subject.SubjectName,
                                                             AgeRange = age.AgeRange,
                                                            
                                                             
                                                         };
            var b = _tutorviewmodel.FirstOrDefault();

            return _tutorviewmodel.FirstOrDefault();

        }

        public List<TutorViewModel> SearchSubjects(string search)
        {
            IQueryable<TutorViewModel> _tutorviewmodel = from subject in _context.Subjects
                                                         from tutor in _context.Tutors
                                                         from user in _context.Users
                                                         from age in _context.AgeRanges
                                                         from role in _context.Roles
                                                         where tutor.TutorLocation == search || age.AgeRange == search || subject.SubjectName == search
                                                         && tutor.TutorID == user.UserID
                                                         select new TutorViewModel
                                                         {
                                                             TutorID = tutor.TutorID,
                                                             FirstName = tutor.FirstName,
                                                             Location = tutor.TutorLocation, 
                                                             Address = user.Address,
                                                             Role = role.RoleName,
                                                             Username = user.UserName,
                                                             SubjectName = subject.SubjectName,
                                                             AgeRange = age.AgeRange,
                                                            
                                                             
                                                         };

            var s = _tutorviewmodel.ToList();
            return _tutorviewmodel.ToList();
        }

        public List<TutorViewModel> SearchSubjects()
        {
            IQueryable<TutorViewModel> _tutorviewmodel = //from subject in _context.Subjects
                                                         //from tutor in _context.Tutors
                                                         //from user in _context.Users

                                                         from tutor in _context.Tutors
                                                         //from subject in _context.Subjects
                                                         from user in _context.Users
                                                         from role in _context.Roles
                                                         where tutor.UserID == user.UserID

                                                         //&& subject.SubjectID == user.UserID

                                                         select new TutorViewModel
                                                         {
                                                             TutorID = tutor.TutorID,
                                                             FirstName = user.FirstName,
                                                             Address = user.Address,
                                                             Role = role.RoleName,
                                                             Username = user.UserName,
                                                             //SubjectName = subject.SubjectName,
                                                            // AgeRange = subject.AgeRange,
                                                             //Location = subject.Location

                                                                                                                                                                                                                                                 
                                                         };

            var a =  _tutorviewmodel.ToList();
            return _tutorviewmodel.ToList();
        }

      
    }



}

