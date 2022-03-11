using System;

namespace SwitchStatementsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string subject = "Spanish";

            Console.WriteLine("choose a subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "Spanish":
                    Console.WriteLine("You are in the right class!");
                    break;
                case "English":
                    Console.WriteLine("We don't do that here.");
                    break;
                case "Science":
                    Console.WriteLine("We don't cut frogs here.");
                    break;
                case "Computers":
                    Console.WriteLine("that class is tomorrow.");
                    break;
                default:
                    Console.WriteLine("We teach spanish here.");
                    break;
            }
        }
    }
}
