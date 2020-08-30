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

        //the  class user type needs to match what is returned. The interface must match to the link to return the database.  
    }





}
