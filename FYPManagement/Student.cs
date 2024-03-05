using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagement
{
    internal class Student:Person
    {
        public string RegistrationNumber { get; set; }
        

        public Student(string regNo, string fName, string lName, string contact, string email, int gender)
        {
            RegistrationNumber = regNo;
            FirstName = fName;
            LastName = lName;
            Contact = contact;
            Email = email;
            this.gender = gender;
        }
    }
}
