//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SecondAssignment
//{
//    public class Employee
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string Email { get; set; }
//        public string Phone { get; set; }
//        public int Age { get; set; }
//        public string JobTitle { get; set; }
//        public int YearsOfExperience { get; set; }
//        public decimal Salary { get; set; }
//        public string Department { get; set; }
//    }

//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Employee
    {
        //  First Name, Last Name,Email,Phone,Gender,Age,Job Title, Years Of Experience, Salary, Department
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string JobTitle { get; set; }
        public string YoE { get; set; }
        public string Salary { get; set; }
        public string Department { get; set; }
        public Employee() { }
        public Employee(string firstName, string lastName, string email, string phone, string gender, string age, string job, string yoE, string salary, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Gender = gender;
            Age = age;
            JobTitle = job;
            YoE = yoE;
            Salary = salary;
            Department = department;
        }
    }
}
