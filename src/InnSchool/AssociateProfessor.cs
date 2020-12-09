using System;
using System.Collections.Generic;
using System.Linq;

namespace InnSchool
{
    public class AssociateProfessor
    {
        public List<Professor> AssociateProfessors;
        private int id;
        
        private int Id
        {
            get
            {
                return id;
            }
            set 
            {
                id = 10000;
            }
        }
        public AssociateProfessor()
        {
            AssociateProfessors = new List<Professor>();
        }
        public void AssociateProfessorData()
        {
            Console.WriteLine("1.Add AssociateProfessors    2.Operations");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddAssociateProfressors();
                    break;
                case 2:
                    Operations();
                    break;
                default:
                    Console.WriteLine("Enter valid choice ");
                    break;

            }
        }

        private void AddAssociateProfressors()
        {
            String Name;
            long salary;
            try
            {
                Console.Write("Enter name : ");
                Name = Console.ReadLine();
                Console.Write("Enter salary : ");
                salary = Convert.ToInt64(Console.ReadLine());
                Professor associate = new Professor(Name, ++Id, "AssociateProfessor", salary);
                SetProfessorDetails(associate);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, Enter details properly!  ");
            }
        }
        public void SetProfessorDetails(Professor NewAssistantProfessor)
        {
            AssociateProfessors.Add(NewAssistantProfessor);
            Console.WriteLine($"Hey! { NewAssistantProfessor.Name } , you are Added succesfully");
        }

        private void Operations()
        {
            Console.WriteLine("1.Show salary   2.Update Salary ");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt16(Console.ReadLine());
            try
            {
                switch (choice)
                {
                    case 1:
                        ShowSalary();
                        break;
                    case 2:
                        ShowSalaryUpdate();
                        break;
                    default:
                        Console.WriteLine("Enter valid choice ");
                        break;
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No Associate Professors");
            }
        }

        void ShowSalary()
        {
            Console.WriteLine("\n\nSALARIES OF ASSOCIATE PROFESSORS");
            if (AssociateProfessors.ToList().Count > 0)
            {
                foreach (var professor in AssociateProfessors)
                {
                    Console.WriteLine(professor.id + "   " + professor.Name + "   " + professor.salary);
                }
            }
            else
            {
                Console.WriteLine("No associates professors.");
            }
        }

        public IEnumerable<Professor> SalaryUpdate()
        {
            AssociateProfessors.Where(professor => professor.salary <= 2000).ToList().ForEach(professor => professor.salary = professor.salary + 50000);
            var Assistants = from professor in AssociateProfessors
                             select professor;
            return Assistants;

        }
        public void ShowSalaryUpdate()
        {
            Console.WriteLine("\n\nUPDATED SALARIES OF ASSOCIATE PROFESSORS");
            var associates = SalaryUpdate();
            if (AssociateProfessors.ToList().Count > 0)
            {
                foreach (var professor in associates)
                {
                    Console.WriteLine(professor.id + "   " + professor.Name + "   " + professor.salary);
                }
            }
            else
            {
                Console.WriteLine("No associates professors.");
            }
        }
    }
}