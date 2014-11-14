using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of the course class
            Course course1 = new Course();
            Course course2 = new Course("SeedPaths", "A");
            //calling methods on an object
            //course1.DisplayCourseInfo();
            //course2.DisplayCourseInfo();

            Student Pat = new Student("Pat", "McClary");
            Pat.Courses.Add(new Course("Professional Development", "B"));
            Pat.Courses.Add(new Course("Programming", "D"));
            Pat.Courses.Add(new Course("Being Rad", "A"));

            Student Kyle = new Student("Kyle", "Wood");
            Kyle.Courses.Add(new Course("Whovian Culture", "A"));
            Kyle.Courses.Add(new Course("History of the Doctor", "c"));

            Pat.PrintAllStudentInfo();
            Console.WriteLine("\n\n");
            Kyle.PrintAllStudentInfo();
            

            Console.ReadKey();
        }
    }

    public class Course
    {
        //1. define its properties
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //creating a read-only property
        private int _gradePoints;
        public int GradePoints
        {
            get
            {
                return _gradePoints;
            }
        }

        private string _letterGrade;
        public string LetterGrade
        {
            get { return _letterGrade; }
            set
            {
                _letterGrade = value.ToUpper();
                //also change the value of the 
                // grade points
                switch (_letterGrade)
                {
                    case "A":
                        _gradePoints = 4;
                        break;
                    case "B":
                        _gradePoints = 3;
                        break;
                    case "C":
                        _gradePoints = 2;
                        break;
                    case "D":
                        _gradePoints = 1;
                        break;
                    default:
                        _gradePoints = 0;
                        break;
                }
            }
        }

        //Step 2: Constructors
        public Course()
        {
            //parameterless constructor
            this.Name = "Undefined";
            this.LetterGrade = "F";
        }

        //overload, with parameters
        public Course(string courseName, string letterGrade)
        {
            this.Name = courseName;
            this.LetterGrade = letterGrade;
        }

        //Step 3: Creating it's methods
        public void DisplayCourseInfo()
        {
            Console.WriteLine("{0}: {1}", this.Name, this.LetterGrade);
        }
    }

    public class Student
    {
        //Step 1: define properties for a student
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private List<Course> _courses;
        public List<Course> Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }

        public double GPA
        {
            get
            {
                if (this.Courses.Any()) { 
                    return this.Courses.Average(x => x.GradePoints);
                }
                else
                {
                    return -1;
                }
            }
        }
        
        //Step 2: Constructors!
        public Student()
        {
            this.FirstName = "undefined";
            this.LastName = "undefined";
            this.Courses = new List<Course>();
        }

        // : this() calls the parameterless constructor
        // above
        public Student(string firstName, string lastName) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //step 3: methods
        public void PrintAllStudentInfo()
        {
            Console.WriteLine("Student: {0} {1}", this.FirstName, this.LastName);
            //this has the same functionality as the foreach loop
            // below
            //this.Courses.ForEach(x => x.DisplayCourseInfo());
            foreach (var course in Courses)
            {
                course.DisplayCourseInfo();
            }
            Console.WriteLine("GPA: {0}", this.GPA);
        }

    }
}
