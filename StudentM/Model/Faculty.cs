using System;
using System.Collections.Generic;
using System.Text;

namespace StudentM.Model
{
    public class Faculty : AbtractUniversity
    {
        public Faculty(int id, string name) : base(id, name)
        {
            this.ID = id;
            this.Name = name;
        }
        public Faculty()
        {

        }
        public List<ClassInFaculty> classInFaculties = new List<ClassInFaculty>();
    }
}
