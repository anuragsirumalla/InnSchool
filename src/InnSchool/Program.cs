using System;
using System.Collections.Generic;

namespace InnSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            string FinalStatus = "start";
            AssistantProfessor assistant = new AssistantProfessor();
            AssociateProfessor associate = new AssociateProfessor();
            Console.WriteLine("\n\n\n                   InnSchool              ");
            while (FinalStatus.Equals("start"))
            {
                Console.WriteLine("\n1.Assistant Professors     2. Associate Professors      3.Exit");
                Console.Write("Enter your choice : ");
                try
                {
                    int choice = Convert.ToInt16(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            assistant.AssistantProfessorData();
                            break;
                        case 2:
                            associate.AssociateProfessorData();
                            break;
                        case 3:
                            Console.WriteLine("Application stopped ");
                            FinalStatus = "stop";
                            break;
                        default:
                            Console.WriteLine("Enter valid choice ");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("please, Enter valid choice .");
                }
            }
        }
    }
}
