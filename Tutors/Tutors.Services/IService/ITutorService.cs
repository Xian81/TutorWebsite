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

        // get
        User GetTutor(int id);


        // add 
        void AddTutor(User user);

        //delete

        void DeleteTutor(User user);

        //edit 

        void EditTutor(User user);

        //Tutor view model 

        List<User> GetTutors();
    }
}
