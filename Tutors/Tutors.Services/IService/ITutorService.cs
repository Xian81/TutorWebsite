using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutors.Data;


namespace Tutors.Services.IService
{
    public interface ITutorService
    {

        User GetUser(int id);

        void AddUser(User user);

        void DeleteUser(User user);

        void EditUser(User user);
               
        List<User> GetUsers();



        //Tutor CRUD Funct

        Tutor GetTutor(int id);

        void AddTutor(Tutor tutor);

        void DeleteTutor(Tutor tutor);

        void EditTutor(Tutor tutor);

        List<Tutor> GetTutors();


    }
}
