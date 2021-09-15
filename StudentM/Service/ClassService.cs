using StudentM.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentM.Service
{
    class ClassService
    {
        public ClassInFaculty add()
        {
            ClassInFaculty classInFaculty = new ClassInFaculty();
            Console.Write("Input Id class: ");
            classInFaculty.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input name class: ");
            classInFaculty.Name = Console.ReadLine();
            return classInFaculty;
        }
    }
}
