using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutors.Data.View_Model
{
    public class TutorViewModel
    { 


        [Key]
        public int TutorId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Role { get; set; }

        public string Username { get; set; }

        public string SubjectName { get; set;}

        public string AgeRange { get; set; }

        public string Location  { get; set; }

        public string Level { get; set; }

    }









    }

