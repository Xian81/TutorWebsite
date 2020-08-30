using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutors.Data;
using Tutors.Data.DAO;
using Tutors.Data.IDAO;
using Tutors.Data.View_Model;
using Tutors.Services.IService;

namespace Tutors.Services.Service
{
    public class SubjectService : ISubjectService
    {

        private ISubjectDAO _subjectDAO;

        public SubjectService()

        {

            _subjectDAO = new SubjectDAO();

        }


        public List<Subject> GetSubjects()
        {
            return _subjectDAO.GetSubjects();
        }

        public Subject GetSubject(int id)
        {

            return _subjectDAO.GetSubject(id);

        }

        public void EditSubject(int? id)
        {
            _subjectDAO.EditSubject(id);

        }

        public void DeleteSubject(Subject subject)
        {
            _subjectDAO.DeleteSubject(subject);
        }

        public void AddSubject(Subject subject)
        {
            _subjectDAO.AddSubject(subject);



        }

        public TutorViewModel GetTutorViewModel(int id)
        {
            return _subjectDAO.GetTutorViewModel(id);

        }


        public List<User> Users()
            {

            return _subjectDAO.Users();

            }

        public List<TutorViewModel> SearchSubjects(string search)
        {
            return _subjectDAO.SearchSubjects( search);
        }

        public List<TutorViewModel> SearchSubjects()
        {
            return _subjectDAO.SearchSubjects();
        }
    }
 }
