using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutors.Data.View_Model;

namespace Tutors.Data.IDAO
{
    


    public interface ISubjectDAO
    {

        List<Subject> GetSubjects();

        Subject GetSubject(int id);

        void EditSubject(int? id);

        void DeleteSubject(Subject subject);

        List<User> Users();

        void AddSubject(Subject subject);

        TutorViewModel GetTutorViewModel(int id);

        List<TutorViewModel> SearchSubjects(string search);
        List<TutorViewModel> SearchSubjects();
    }
}
