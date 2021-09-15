using StudentM.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentM.Service
{
    class StudentService 
    {
        public Student add()
        {
            Student student = new Student();
            Console.Write("Input id: ");
            student.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  name: ");
            student.Name = Console.ReadLine();
            return student;
        }

    }
}
