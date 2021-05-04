using System;
using System.Collections.Generic;

namespace LeaveSystem
{
    class Program
    {
        static List<string> actions = new List<string>()
            { "Leave Request (type 0)", "Login as Admin (type 1)", "exit app (type 2)" };
        static void Main(string[] args)
        {

            Console.WriteLine("\n \n * * Welcome! * * ");
            Console.WriteLine("\n * Student System Management System *");
            Console.ReadKey();

            for (int useraction = GetUserAction();
     useraction != actions.IndexOf("exit app (type 2)");
     useraction = GetUserAction())
            {
                switch (useraction)
                {
                    case 0:
                        Console.WriteLine(LeaveRequest());
                        break;
                    case 1:

                        Console.WriteLine(Login());
                        break;
                    default:
                        Console.WriteLine("Invalid! Try again.");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Application exiting...");
            Console.ReadKey();
        }


        static string Login()
        {
            int logCount = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write(" \n Username: ");
                string username = Console.ReadLine();

                Console.Write("\n Password: ");
                string password = Console.ReadLine();

                if (username != "admin" || password != "pass")
                {
                    Console.WriteLine("Your username or password is incorrect! \n Please try again.");
                    logCount++;
                }
                else
                {
                    break;
                }
            }
            if (logCount > 2)
            {
                Console.WriteLine("Your out of Login attempts. \n Try again later.");
            }
            else
            {
                Console.WriteLine("\n Login Successful!");
            }
            return "";
        }

        static string LeaveRequest()
        {
            string name, birthday, employeeId, numday, reason;

            Console.WriteLine("\n \n Please fill out this form.");

            Console.WriteLine("Name: \n");
            name = Console.ReadLine();

            Console.WriteLine("Birthday: \n");
            birthday = Console.ReadLine();

            Console.WriteLine("Employee Id number: \n");
            employeeId = Console.ReadLine();

            Console.WriteLine("How many days are you going for a leave? \n");
            numday = Console.ReadLine();

            Console.WriteLine("Please put your valid reason why you were applying for a leave. \n");
            reason = Console.ReadLine();


            Console.WriteLine("\n \n \n * * Please review the data you've enter. * * ");
            Console.WriteLine($"I am {name} born in {birthday} with Employee Id number {employeeId}. \n I am applying for a {numday} day/s of leave because {reason}. \n Thank you!");
            return "";
        }
        
      

        static int GetUserAction()
        {
            ShowOptions();
            Console.Write("ACTION: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void ShowOptions()
        {
            Console.WriteLine("Choose any of the following options. ");

            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }
        }
    }
}





    


