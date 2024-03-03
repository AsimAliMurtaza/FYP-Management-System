using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagement
{
    internal class Advisor:Person
    {
        public string Designation { get; set; }
        public string Salary { get; set; }


        public Advisor(string fName, string lName, string contact, string email, string designation, string salary, int gender, string dob)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Contact = contact;
            this.Email = email;
            this.Designation = designation;
            this.Salary = salary;
            this.gender = gender;
            this.dob = dob;
        }
     
    }
}
