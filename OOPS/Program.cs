using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{

    // Abstraction: Base class
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Abstract method for GPA calculation
        public abstract (double, string) CalculateGPA();
    }

    // Student class inheriting from Person
    public class Student : Person
    {
        public List<double> Grades { get; set; }

        public Student(string firstName, string lastName, List<double> grades)
            : base(firstName, lastName)
        {
            Grades = grades;
        }

        // Implementing CalculateGPA without recursive patterns
        public override (double, string) CalculateGPA()
        {
            double total = 0;
            foreach (var grade in Grades)
            {
                total += grade;
            }

            double average = total / Grades.Count;
            string result;

            if (average >= 90)
            {
                result = "A";
            }
            else if (average >= 80)
            {
                result = "B";
            }
            else if (average >= 70)
            {
                result = "C";
            }
            else if (average >= 60)
            {
                result = "D";
            }
            else
            {
                result = "F";
            }

            return (average, result);
        }
    }

    // Course class for managing students
    public class Course
    {
        private List<Student> students = new List<Student>();
        public string CourseName { get; private set; }

        public Course(string courseName)
        {
            CourseName = courseName;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }

    // Interface for teaching
    public interface ITeachable
    {
        void Teach();
    }

    // Professor class inheriting from Person and implementing ITeachable
    public class Professor : Person, ITeachable
    {
        public Professor(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public void Teach()
        {
            Console.WriteLine($"{FirstName} {LastName} is teaching a class.");
        }

        // Implementing a placeholder CalculateGPA method for Professor
        public override (double, string) CalculateGPA()
        {
            // Placeholder value for GPA
            return (-1, "N/A");
        }
    }





    class Program
    {
        static void Main()
        {
            // Null Coalescing Operator to handle null list
            List<Student> studentsList = null;
            var students = studentsList ?? new List<Student>();

            // Adding students to the course
            Course course = new Course("Computer Science");
            students.Add(new Student("Alice", "Smith", new List<double> { 85, 90, 78 }));
            students.Add(new Student("Bob", "Johnson", new List<double> { 92, 88, 75 }));
            students.Add(new Student("Charlie", "Brown", new List<double> { 78, 80, 85 }));

            foreach (var student in students)
            {
                course.AddStudent(student);
            }

            // LINQ operations: Finding students with high GPA
            var highGpaStudents = course.GetStudents().Where(s => s.CalculateGPA().Item1 >= 85);

            Console.WriteLine("High GPA Students:");
            foreach (var student in highGpaStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            // Ternary Operator to display the course name
            string courseName = course.CourseName != null ? course.CourseName : "No Course Name Available";
            Console.WriteLine($"Course Name: {courseName}");

            // Teaching professor
            Professor professor = new Professor("Dr. John", "Doe");
            professor.Teach();
        }
    }

}
