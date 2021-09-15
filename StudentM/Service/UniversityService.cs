using StudentM.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentM.Service
{  
    class UniversityService
    {
      
        public static List<AbtractUniversity> abtractUniversities = new List<AbtractUniversity>();
        public void add(AbtractUniversity abtractUniversity)
        {
            abtractUniversities.Add(abtractUniversity);
        }
        public void remove(int id)
        {
           
            foreach (AbtractUniversity abtractUniversity in abtractUniversities)
            {
                if (abtractUniversity.ID == id)
                {
                    abtractUniversities.Remove(abtractUniversity);
                }
            }
        }
        public void show()
        {
            foreach (AbtractUniversity abtractUniversity in abtractUniversities)
            {
                Console.WriteLine("Id university:{0}", abtractUniversity.ID);
                Console.WriteLine("Name university:{0}", abtractUniversity.Name);
            }
        }
        public void add(int universityId)
        {
            FacultyService faculty = new FacultyService();
            foreach (AbtractUniversity university in abtractUniversities)
            {
                if(universityId == university.ID)
                {
                    university.faculties.Add(faculty.add());
                }
            }
        }
        public void add(int universityId,int facutyId)
        {
            ClassService classService = new ClassService();
            foreach (AbtractUniversity university in abtractUniversities)
            {
                if (universityId == university.ID)
                {
                    foreach (Faculty faculty in university.faculties)
                    {
                      if(facutyId== faculty.ID)
                        {
                            faculty.classInFaculties.Add(classService.add());
                        }
                    }
                }
            }
        }
        public void add(int universityId, int facutyId,int ClassId){
            StudentService student = new StudentService();
            foreach (AbtractUniversity university in abtractUniversities)
            {
                if (universityId == university.ID)
                {
                    foreach (Faculty faculty in university.faculties)
                    {
                        if (facutyId == faculty.ID)
                        {
                            foreach (ClassInFaculty classInFaculty in faculty.classInFaculties)
                            {
                                if (facutyId == faculty.ID)
                                {
                                    classInFaculty.students.Add(student.add());
                                }
                            }
                        }
                    }
                }
            }
        }
       
        
    }
}
