namespace task_3_test
{
    class Instructor
    {
        public int InstructorId;
        public string Name;
        public string Specialization;

        public Instructor(int instructorId = 1000, string name = "Unknown", string specialization = "Unknown")
        {
            InstructorId = instructorId;
            Name = name;
            Specialization = specialization;
        }

        public string PrintDetails()
        {
            return $"Id: {InstructorId}, Name: {Name}, Specialization: {Specialization} ";
        }
    }
    class Course
    {
        public int CourseId;
        public string Title;
        public Instructor Instructor;

        public Course(int courseId = 100, string title = "Unknown", Instructor instructor = null)
        {
            CourseId = courseId;
            Title = title;
            if (instructor != null)
            {
                Instructor = instructor;
            }
            else
            {
                Instructor = new Instructor();
            }

            // حل تاني افضل لو عايز تعمل سيرش عليه بيعمل نفس الحاجة بس افضل ك كود نظيف
            // Instructor = instructor ?? new Instructor();
        }

        public string PrintDetails()
        {
            return $"Id: {CourseId}, Title: {Title}, Instructor: {Instructor.Name}";
        }

    }
    class Student
    {
        public int StudentId;
        public string Name;
        public int Age;
        private List<Course> Courses;

        public Student(int studentId = 1000, string name = "unKnown", int age = 0)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
            Courses = new List<Course>();
        }

        public bool EnrollCourse(Course course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
                return true;
            }
            return false;
        }

        public string PrintDetails()
        {
            string Details = $"Id: {StudentId}, Name: {Name}, Age: {Age}";
            if (Courses.Count > 0)
            {
                for (int i = 0; i < Courses.Count; i++)
                {
                    Details += $"\n  CourseId: {Courses[i].CourseId}, Title: {Courses[i].Title}, Instructor: {Courses[i].Instructor.Name}";
                }
            }
            return Details;
        }
    }

    class School
    {
        List<Student> Students;
        List<Course> Courses;
        List<Instructor> Instructors;

        public School()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
            Instructors = new List<Instructor>();
        }

        public bool AddStudent(Student student)
        {
            if (Students.Contains(student))
            {
                return false;
            }
            Students.Add(student);
            return true;
        }

        public bool AddCourse(Course course)
        {
            if (Courses.Contains(course))
            {
                return false;
            }
            Courses.Add(course);
            return true;
        }

        public bool AddInstructor(Instructor instructor)
        {
            if (Instructors.Contains(instructor))
            {
                return false;
            }
            Instructors.Add(instructor);
            return true;
        }


        public Student? FindStudent(int studentId)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].StudentId == studentId)
                {
                    return Students[i];
                }
            }
            return null;
        }

        public Course? FindCourse(int courseId)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].CourseId == courseId)
                {
                    return Courses[i];
                }
            }
            return null;
        }

        public string ShowAllCourses()
        {
            string allCourses = "";
            for (int i = 0; i < Courses.Count; i++)
            {
                allCourses += $"{Courses[i].PrintDetails()} \n";
            }
            return allCourses;
        }

        public string ShowAllStudents()
        {
            string allStudents = "";
            for (int i = 0; i < Students.Count; i++)
            {
                allStudents += $"{Students[i].PrintDetails()} \n";
            }
            return allStudents;
        }


        public string ShowAllInstructors()
        {
            string allInstructors = "";
            for (int i = 0; i < Instructors.Count; i++)
            {
                allInstructors += $"{Instructors[i].PrintDetails()}  \n";
            }
            return allInstructors;
        }


        public Instructor? FindInstructor(int instructorId)
        {
            for (int i = 0; i < Instructors.Count; i++)
            {
                if (Instructors[i].InstructorId == instructorId)
                {
                    return Instructors[i];
                }
            }
            return null;
        }

        public bool EnrollStudentInCourse(int studentId, int courseId)
        {
            Student std = null;
            Course crs = null;
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].StudentId == studentId)
                {
                    std = Students[i];
                }
            }

            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].CourseId == courseId)
                {
                    crs = Courses[i];
                }
            }

            if (std != null && crs != null)
            {
                std.EnrollCourse(crs);
                return true;
            }
            return false;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Instructor inst1 = new Instructor(1, "Ahmed", "C#");
                Instructor inst2 = new Instructor(2, "Mohamed", "C++");
                Instructor inst3 = new Instructor(3, "Ali", "Python");
                Instructor inst4 = new Instructor(4, "Soha", "Java Script");
                Instructor inst5 = new Instructor(5, "Islam", "Java");


                Course crs1 = new(1, "C#", inst1);
                Course crs2 = new(2, "C++", inst2);
                Course crs3 = new(3, "Python", inst3);
                Course crs4 = new(4, "Java Script", inst4);
                Course crs5 = new(5, "Java", inst5);


                Student std1 = new(1, "Youssef", 30);
                Student std2 = new(2, "ahmed", 20);
                Student std3 = new(3, "Abdo", 24);
                Student std4 = new(4, "Modric", age: 25);
                //std1.EnrollCourse(crs1);
                //std1.EnrollCourse(crs1);
                //std1.EnrollCourse(crs2);
                //std1.EnrollCourse(crs3);

                School sch = new School();
                // add instructors
                sch.AddInstructor(inst1);
                sch.AddInstructor(inst2);
                sch.AddInstructor(inst3);
                sch.AddInstructor(inst4);
                sch.AddInstructor(inst5);

                // add courses  
                sch.AddCourse(crs1);
                sch.AddCourse(crs2);
                sch.AddCourse(crs3);
                sch.AddCourse(crs4);
                sch.AddCourse(crs5);

                // add Students

                sch.AddStudent(std1);
                sch.AddStudent(std2);
                sch.AddStudent(std3);
                sch.AddStudent(std4);

                sch.EnrollStudentInCourse(1, 1);
                sch.EnrollStudentInCourse(1, 4);

                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");

                Student std = sch.FindStudent(1);
                Console.WriteLine(std.PrintDetails());

                Console.WriteLine(sch.ShowAllCourses());
                Console.WriteLine("////////////////////////////////");
                Console.WriteLine(sch.ShowAllInstructors());
                Console.WriteLine("////////////////////////////////");
                Console.WriteLine(sch.ShowAllStudents());


            }
        }
    }
}
