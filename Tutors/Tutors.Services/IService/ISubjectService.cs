using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutors.Data;
using Tutors.Data.View_Model;


namespace Tutors.Services.IService
{
 public interface ISubjectService
    {

        List<Subject> GetSubjects();

        Subject GetSubject(int id);

        void EditSubject(int? id);

        void DeleteSubject(Subject subject);

        void AddSubject(Subject subject);

        TutorViewModel GetTutorViewModel(int id);

        List<User> Users();

        List<TutorViewModel> SearchSubjects(string search);

        List<TutorViewModel> SearchSubjects();

        
    }
}
