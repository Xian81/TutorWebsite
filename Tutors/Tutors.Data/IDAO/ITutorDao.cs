using System.Collections.Generic;

namespace Tutors.Data.IDAO
{
    public interface ITutorDao
    {

        User GetTutor(int id);
              
        void DeleteTutor(User user);

        void EditTutor(User user);

        List<User> GetTutors();

        void AddTutor(User user);

         
    }





}
