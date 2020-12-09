using System;
using System.Collections.Generic;
using System.Linq;

namespace InnSchool
{
    public class AssistantProfessor
    {

        public List<Professor> AssistantProfessors;
        private int Id = 10000;
        public AssistantProfessor()
        {
            AssistantProfessors = new List<Professor>();
        }
        public void SetProfessorDetails(ref Professor NewAssistantProfessor)
        {
            AssistantProfessors.Add(NewAssistantProfessor);
            Console.WriteLine($"Hey! { NewAssistantProfessor.Name } , you are Added succesfully");
        }
        private IEnumerable<Professor> GetAssistantProfessorsSalaryGreaterThanTwentyThousand()
        {
            var Assistants = from professor in AssistantProfessors
                             where professor.salary >= 20000
                             orderby professor.salary
                             select professor;
            return Assistants;
        }
        public void ShowAssistantProfessorsSalaryGreaterThanTwentyThousand()
        {
            var Assistants = GetAssistantProfessorsSalaryGreaterThanTwentyThousand();
            if (Assistants.ToList().Count > 0)
                foreach (var professor in Assistants)
                {
                    Console.WriteLine(professor.Name + "   " + professor.salary);
                }
            else
            {
                Console.WriteLine("No assistant professors.");
            }

        }
        public void ShowAssistantProfessorsInAlphabeticalOrder()
        {
            var Assistants = GetAssistantProfessorsInAlphabeticalOrder();
            if (AssistantProfessors.ToList().Count > 0)
            {
                foreach (var professor in Assistants)
                {
                    Console.WriteLine(professor.Name + "     " + professor.id + "     " + professor.salary);
                }
            }
            else
            {
                Console.WriteLine("No assistant professors.");
            }
        }
        private IEnumerable<Professor> GetAssistantProfessorsInAlphabeticalOrder()
        {
            var Assistants = from professor in AssistantProfessors
                             orderby professor.Name descending
                             select professor;
            return Assistants;
        }
        private void Operations()
        {
            Console.WriteLine("1.Professors in AlphabticalOrder   2.Salary Greater than 20K ");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowAssistantProfessorsInAlphabeticalOrder();
                    break;
                case 2:
                    ShowAssistantProfessorsSalaryGreaterThanTwentyThousand();
                    break;
                default:
                    Console.WriteLine("Enter valid choice ");
                    break;
            }

        }
        public void AddAssistantProfressors()
        {
            try
            {
                Console.Write("Enter name : ");
                String Name = Console.ReadLine();
                Console.Write("Enter salary : ");
                long salary = Convert.ToInt64(Console.ReadLine());
                Professor NewAssistant = new Professor(Name, ++Id, "AssistantProfessor", salary);
                SetProfessorDetails(ref NewAssistant);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, Enter details properly!  ");
            }
        }
        public void AssistantProfessorData()
        {
            Console.WriteLine("1.Add AssistantProfessors    2.Operations");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt16(Console.ReadLine());
            try
            {
                switch (choice)
                {
                    case 1:

                        AddAssistantProfressors();

                        break;
                    case 2:
                        Operations();
                        break;
                    default:
                        Console.WriteLine("Enter valid choice ");
                        break;

                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No Assistant Professors");
            }
        }


















    }
}