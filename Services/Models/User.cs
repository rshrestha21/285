using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Models
{
    public class User
    {
        public int Id { get; set; }

       

        public string FName { get; set; }

        public string LName{ get; set; }


        public string Username { get; set; }

        public string Password { get; set; }

        public string Gender { get; set; }

        public string Address { get; set;}

        public int Phonenumber { get; set; }

        public DateTime DateofBirth { get; set; }

        public ICollection<Service> Services { get; set; }
    }

}