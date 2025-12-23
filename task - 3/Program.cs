namespace task___3 { 

internal class Program
{
     class Student
    {


        public string studentId;
        public string studentName;
        public int studentAge;
        public List<Course> courses;

        public Student(string name, string Id, int age)
        {
            studentName = name;
            studentId = Id;
            studentAge = age;
            courses = new List<Course>();

        }
        public bool EnrollCourse(Course course)
        {
            if (!courses.Contains(course)) { 
                courses.Add(course);
                return true;
            }
            return false;

        }
        public string printStudentDetails()
        {
            string Details = $"ID: {studentId}, Name: {studentName}, Age: {studentAge} ";
            if (courses.Count > 0)
            {

                for (int i = 0; i < courses.Count; i++)
                {
                    Details += $"\n  CourseId: {courses[i].courseId}, Title: {courses[i].courseName}, Instructor: {courses[i].instuctor.instructorName}";
                }
            }
            return Details;

        }

    }
    class Course
    {
        public string courseId;
        public string courseName;

        public Instructor instuctor;

        public Course(string id, string name, Instructor instuctor)
        {
            courseId = id;
            courseName = name;
            this.instuctor = instuctor;
        }


       public string printCourseDetails()
        {
            return $"ID: {courseId}, Name: {courseName}, instuctor: {instuctor}";
        }
    }
    class Instructor
    {
        public string instructorId;
        public string instructorName;
        public string department;

        public Instructor(string id, string name, string department)
        {
            instructorId = id;
            instructorName = name;
            this.department = department;
        }
        public string printInstructorDetails() { 
        
            return $"ID: {instructorId}, Name: {instructorName}, Department: {department}";

        }
    }

    class Database
    {
        List<Student> students;
        List<Course> courses;
        List<Instructor> instructors;
        public Database()
        {
            students = new List<Student>();
            courses = new List<Course>();
            instructors = new List<Instructor>();
        }
        //public void AddStudent()
        //{
        //    Console.WriteLine("Enter Student Name");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Enter Student ID");
        //    string ID = Console.ReadLine();
        //    Console.WriteLine("Enter Student Age");
        //    int age = int.Parse(Console.ReadLine());
        //    Student student1 = new Student(name, ID, age);

        //    Student student = new Student(name, ID, age);
        //    students.Add(student);
        //    Console.WriteLine($"Student {student.studentName} Added Succsesfully");
        //}

        public bool AddStudent(Student student) {
            if (students.Contains(student)) {
                return false;

            }
            students.Add(student);
            return true;

        }

        //public void AddCourse()
        //{
        //    Console.WriteLine("Enter Course Name");
        //    string Iname = Console.ReadLine();
        //    Console.WriteLine("Enter Course Id");
        //    string id = Console.ReadLine();

        //    Console.WriteLine("Enter Instructor Name");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Enter Instructor ID");
        //    string ID = Console.ReadLine();
        //    Console.WriteLine("Enter Instructor Department");
        //    string department = Console.ReadLine();
        //    Instructor instructor = new Instructor(ID, name, department);

        //    instructors.Add(instructor);

        //    Course course = new Course(id, Iname, instructor);
        //    courses.Add(course);
        //    Console.WriteLine($"Course {course.courseName} Added Succsesfully");
        //}

        public bool AddCourse(Course course)
        {
            if (courses.Contains(course))
            {
                return false;
            }
            courses.Add(course);
            return true;
        }




        //public void AddInstructor()
        //{
        //    Console.WriteLine("Enter Instructor Name");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Enter Instructor ID");
        //    string ID = Console.ReadLine();
        //    Console.WriteLine("Enter Instructor Department");
        //    string department = Console.ReadLine();
        //    Instructor instructor = new Instructor(ID, name, department);
        //    instructors.Add(instructor);
        //    Console.WriteLine($"Instructor {instructor.instructorName} Added Succsesfully");
        //}

        public bool AddInstructor(Instructor instructor)
        {
            if (instructors.Contains(instructor))
            {
                return false;
            }
            instructors.Add(instructor);
            return true;
        }

        //public void showInstructors()
        //{
        //    if (instructors.Count == 0)
        //    {
        //        Console.WriteLine("No instructors found.");
        //    }
        //    else
        //    {
        //        foreach (var instructor in instructors)
        //        {
        //            Console.WriteLine($"ID: {instructor.instructorId}, Name: {instructor.instructorName}, Age: {instructor.department}");
        //        }
        //    }
        //}

        public string ShowInstructors()
        {
            string allInstructors = "";
            for (int i = 0; i < instructors.Count; i++)
            {
                allInstructors += $"{instructors[i].printInstructorDetails()}  \n";
            }
            return allInstructors;
        }
        //public void showStudents()
        //{
        //    if (students.Count == 0)
        //    {
        //        Console.WriteLine("No students found.");
        //    }
        //    else
        //    {
        //        foreach (var student in students)
        //        {
        //            Console.WriteLine($"ID: {student.studentId}, Name: {student.studentName}, Age: {student.studentAge}");
        //        }
        //    }
        //}
        //public void showCourses()
        //{
        //    if (courses.Count == 0)
        //    {
        //        Console.WriteLine("No courses found.");
        //    }
        //    else
        //    {
        //        foreach (var course in courses)
        //        {
        //            Console.WriteLine($"ID: {course.courseId}, Name: {course.courseName}");
        //        }
        //    }

        //}







        //public void FindStudent()
        //{
        //    Console.WriteLine("Enter Number To Search For Student");
        //    Console.WriteLine("1. Search by Id");
        //    Console.WriteLine("2. Search by Name");

        //    int choice = int.Parse(Console.ReadLine());

        //    if (choice == 1)
        //    {
        //        Console.WriteLine("Enter Student Id");
        //        string stuID = Console.ReadLine();
        //        bool found = false;

        //        foreach (var student in students)
        //        {
        //            if (stuID == student.studentId)
        //            {
        //                Console.WriteLine($"This Student is Found And His Name Is {student.studentId}");
        //                found = true;
        //                break; 
        //            }
        //        }

        //        if (!found)
        //        {
        //            Console.WriteLine($"The student with Id {stuID} is not found");
        //        }
        //    }
        //    else if (choice == 2)
        //    {
        //        Console.WriteLine("Enter Student Name");
        //        string stuName = Console.ReadLine();
        //        bool found = false;

        //        foreach (var student in students)
        //        {
        //            if (stuName == student.studentName)
        //            {
        //                Console.WriteLine($"This Student is Found And His Id Is {student.studentName}");
        //                found = true;
        //                break;
        //            }
        //        }

        //        if (!found)
        //        {
        //            Console.WriteLine($"The student with Name {stuName} is not found");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid Number");
        //    }
        //}
        public string ShowStudents()
        {
            string allStudents = "";
            for (int i = 0; i < students.Count; i++)
            {
                allStudents += $"{students[i].printStudentDetails()} \n";
            }
            return allStudents;
        }
        public string showCourses()
        {
            string allCourses = "";
            for (int i = 0; i < courses.Count; i++)
            {
                allCourses += $"{courses[i].printCourseDetails()} \n";
            }
            return allCourses;
        }

        public Student FindStudent(string studId)
        {
            for (int i = 0; i < students.Count; i++) {
                if (studId== students[i].studentId) {
                    return students[i];

                }
                
            
            }
            return null;
        }

        //            public void FindCourse()
//            {
//                Console.WriteLine("Enter Number To search");
//                Console.WriteLine("1.Search By ID");
//                Console.WriteLine("1.Search By Name");

//                int choise=int.Parse(Console.ReadLine());

//                if (choise == 1)
//                {
//                    Console.WriteLine("Enter Id To Search");
//                    string courseID = Console.ReadLine();
//                    bool isFound = false;
//                    foreach (var course in courses)
//                    {
//                        if (courseID == course.courseId)
//                        {
//                            isFound = true;
//                            Console.WriteLine($"the course is have this id{courseID} is founded and his name is {course.courseId}");
//                            break;
//                        }
//                        if (!isFound)
//                        {
//                            Console.WriteLine($"the course is have this id{courseID} is not found ");
//                        }
//                    }
//                }

//                else if (choise == 2)
//                {
//                    Console.WriteLine("Enter Name To Search");
//                    string courseName = Console.ReadLine();
//                    bool isFound = false;
//                    foreach (var course in courses)
//                    {
//                        if (courseName == course.courseName)
//                        {
//                            isFound = true;
//                            Console.WriteLine($"the course is have this name {courseName} is founded and his ID is {course.courseId}");
//                            break;
//                        }
//                        if (!isFound)
//                        {
//                            Console.WriteLine($"the course is have this id{courseName} is not found ");
//                        }
//                    }


//                }
//                else
//                {
//                    Console.WriteLine("Invalied Number");
//                }
//}

       public Course FindCourse(string crsID)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (crsID == courses[i].courseId)
                {
                    return courses[i];
                }

                
            }
            return null;
        }

        public bool EnrollStudentInCourse(string studentId, string courseId)
        {
            Student std = null;
            Course crs = null;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].studentId == studentId)
                {
                    std = students[i];
                }
            }

            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].courseId == courseId)
                {
                    crs = courses[i];
                }
            }

            if (std != null && crs != null)
            {
                std.EnrollCourse(crs);
                return true;
            }
            return false;
        }


    }
    static void Main(string[] args)

        {
            Database db = new Database();
            Student stud1 = new Student("Ali", "4545454", 20);

            Course course1 = new Course("C001", "Math", new Instructor("I001", "Dr. Smith", "Mathematics"));
            Instructor inst1 = new Instructor("I002", "Dr. Johnson", "Physics");

            do
            {
                Console.WriteLine("Welcome in Student Managment System: Enter Service You Need");
                Console.WriteLine("1. Add Student ");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course ");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Show All Students");
                Console.WriteLine("6. Show All Courses");
                Console.WriteLine("7. Show All Instructors");
                Console.WriteLine("8. Find the student by id or name");
                Console.WriteLine("9. Fine the course by id or name");
                Console.WriteLine("10. Exit");

                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case (1):
                        {
                            db.AddStudent(stud1);
                            break;
                        }

                    case (2):
                        {
                            db.AddInstructor(inst1);
                            break;
                        }
                    case (3):
                        {
                            db.AddCourse(course1);
                            break;
                        }
                    case (4):
                        {

                        db.EnrollStudentInCourse("c45","s55");
                            break;
                        }
                    case (5):
                        {
                            db.ShowStudents();
                            break;
                        }
                    case (6):
                        {
                            db.showCourses();


                            break;
                        }
                    case (7):
                        {
                            db.ShowInstructors();


                            break;
                        }
                    case (8):
                        {
                            db.FindStudent("45");


                            break;
                        }
                    case (9):
                        {
                            db.FindCourse("65");
                            break;
                        }
                    case (10):
                        {
                            return;
                            break;
                        }

                }
            } while (true);

        }
    
}
}
