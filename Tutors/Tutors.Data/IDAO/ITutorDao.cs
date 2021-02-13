using System.Collections.Generic;

namespace Tutors.Data.IDAO
{
    public interface ITutorDAO
    {

        User GetUser(int id);
              
        void DeleteUser(User user);

        void EditUser(User user);

        List<User> GetUsers();

        void AddUser(User user);


        // Tutors CRUD Funct



        Tutor GetTutor(int id);

        void DeleteTutor(Tutor user);

        void EditTutor(Tutor user);

        List<Tutor> GetTutors();

        void AddTutor(Tutor user);








    }





}
