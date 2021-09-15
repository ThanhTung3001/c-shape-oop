using System;
using System.Collections.Generic;
using System.Text;

namespace StudentM.Model
{
  public class AbtractUniversity
    {
        private int id;
        private string name;

       public int ID {
            get => id;
            set => id = value;
        }
       public string Name
        {
            get => name;
            set => name = value;
        }
        public AbtractUniversity(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public AbtractUniversity()
        {
           
        }
      public  List<Faculty> faculties = new List<Faculty>();
      
    }
}
