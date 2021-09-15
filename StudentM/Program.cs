using StudentM.Model;
using StudentM.Service;
using System;

namespace StudentM
{
    class Program
    {
        UniversityService UniversityService = new UniversityService();
        public void showUniver()
        {
            if (UniversityService.abtractUniversities == null)
            {
                Console.WriteLine("List empty");
            }
            else
            {
                foreach (AbtractUniversity abtractUniversity1 in UniversityService.abtractUniversities)
                {
                    Console.WriteLine(" Id:{0} Name {1}", abtractUniversity1.ID, abtractUniversity1.Name);
                }
            }
        }
        public AbtractUniversity ShowFac(int id)
        {     
              
            foreach (AbtractUniversity abtractUniversity1 in UniversityService.abtractUniversities)
            {
                if (abtractUniversity1.ID == id)
                {
                    return abtractUniversity1;
                }
            }
            return null;
        }
        public void showFAC(AbtractUniversity abtractUniversity)
        {
            if (abtractUniversity.faculties == null)
            {
                Console.WriteLine("List emply");
                return;
            }
            else
            {
                foreach (Faculty faculty in abtractUniversity.faculties)
                {
                    Console.WriteLine("ID :{0} Name: {1}", faculty.ID, faculty.Name);
                }
            }
        }
         public Faculty Faculty(int universityId,int facId)
        {
            AbtractUniversity abtractUniversity = ShowFac(universityId);
            foreach(Faculty faculty  in abtractUniversity.faculties)
            {
                if(faculty.ID== facId)
                {
                    return faculty;
                }
            }
            return null;
        }
        public void ShowClass(Faculty faculty)
        {
            if (faculty.classInFaculties == null)
            {
                Console.WriteLine("List emplty");
                return;
            }
            else
            {
                foreach (ClassInFaculty classInFaculty in faculty.classInFaculties)
                {
                    Console.WriteLine("ID: {0} Name: {1}", classInFaculty.ID, classInFaculty.Name);
                }
            }
        }
        public void functionMenu()
        {
            int key = 0;
            int chooseUID = 0;
            int choooseFID = 0;
            int chooseClassID = 0;
            do
            {
                Console.WriteLine("1.Add University ");
                Console.WriteLine("2.Add Faculty ");
                Console.WriteLine("3.Add Class ");
                Console.WriteLine("4.Add Student  ");
                Console.Write("Choose: ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        AbtractUniversity abtractUniversity = new AbtractUniversity();
                        Console.Write("Input ID University: ");
                        abtractUniversity.ID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input Name University: ");
                        abtractUniversity.Name = Console.ReadLine();
                        UniversityService.add(abtractUniversity);
                        break;
                    case 2:
                        showUniver();
                        Console.Write("Choose University by id :");
                        chooseUID = Convert.ToInt32(Console.ReadLine());
                        UniversityService.add(chooseUID);
                        Console.WriteLine("Add Success! ");
                        break;
                    case 3:
                        showUniver();
                        Console.Write("Choose University by id :");
                        chooseUID = Convert.ToInt32(Console.ReadLine());
                        AbtractUniversity abtractUniversity1 = ShowFac(chooseUID);
                        showFAC(abtractUniversity1);
                        Console.Write("Choose Faculty by id :");
                        choooseFID = Convert.ToInt32(Console.ReadLine());
                        UniversityService.add(chooseUID,choooseFID);
                        break;
                    case 4:
                        showUniver();
                        Console.Write("Choose University by id :");
                        chooseUID = Convert.ToInt32(Console.ReadLine());
                        AbtractUniversity abtractUniversity2 = ShowFac(chooseUID);
                        showFAC(abtractUniversity2);
                        Console.Write("Choose Faculty by id :");
                        choooseFID = Convert.ToInt32(Console.ReadLine());
                        Faculty faculty = Faculty(chooseUID,choooseFID);
                        ShowClass(faculty);
                        Console.WriteLine("Choose Class by id: ");
                        chooseClassID = Convert.ToInt32(Console.ReadLine());
                        UniversityService.add(chooseUID,choooseFID, chooseClassID);
                        break;

                }
            } while (key!=0);
           
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.functionMenu();


        }
    }
}
