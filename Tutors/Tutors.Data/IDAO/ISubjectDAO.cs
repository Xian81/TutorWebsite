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

        List<Subject> getSubjects();

        Subject getSubject(int id);

        void editSubject(int? id);

        void deleteSubject(Subject subject);

        List<User> users();

        void addSubject(Subject subject);

        TutorViewModel getTutorViewModel(int id);

        List<TutorViewModel> searchSubjects(string search);
        List<TutorViewModel> searchSubjects();
    }
}
