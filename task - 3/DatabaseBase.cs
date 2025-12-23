namespace task___3
{
    private class DatabaseBase
    {







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

        public Student FindStudent(string studId)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (studId == students[i].studentId)
                {
                    return students[i];

                }
                return null;

            }

        }
    }
}