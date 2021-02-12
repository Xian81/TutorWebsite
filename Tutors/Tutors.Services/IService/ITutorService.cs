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

        User GetTutor(int id);


        void AddTutor(User user);

        void DeleteTutor(User user);

         void EditTutor(User user);

        //Tutor view model 

        List<User> GetTutors();
    }
}
