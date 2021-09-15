using StudentM.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentM.Service
{
    class FacultyService 
    {
        public Faculty add()
        {
            Faculty faculty = new Faculty();
            Console.Write("Input Faculty Id: ");
            faculty.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Faculty name: ");
            faculty.Name = Console.ReadLine();
            return faculty;
        }
      
    }
}
