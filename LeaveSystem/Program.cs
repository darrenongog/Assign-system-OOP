using System;

namespace LeaveSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            string name, birthday, employeeId, numday, reason;
            string pass = null;
            string admin = null;
            string username = admin, password = pass;
            
          


            Console.WriteLine("\n \n * * Welcome! * * ");
            Console.WriteLine("\n * Student System Management System *");

            Console.WriteLine("Applying for a Leave? Please type 'Leave'.");
            Console.WriteLine("Log In as Admin? Please type 'Admin'.");
            String OptionSelected = Console.ReadLine().ToLower();

            if (OptionSelected.Equals("leave"))
            {
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
                Console.WriteLine($"I am {name} born in {birthday} with Employee Id number {employeeId}. I am applying for a {numday} day/s of leave because {reason}. Thank you!");

                

            }

            else if (OptionSelected.Equals("admin"))
            {
                Console.WriteLine("\n \n * * Administration Login * * ");
                Console.WriteLine("Username: \n ");
                username = Console.ReadLine();

                Console.WriteLine("Password: \n ");
                password = Console.ReadLine();

                if (username != admin && password != pass)
                {

                    Console.WriteLine("Login Successful!");
                    Console.ReadKey();
            

                }
                else
                {

                    Console.WriteLine("The Username and Password you've enter is incorrect!");
                    Console.WriteLine("Please try Again!");
                    return;
                }

            }

            else
            {

                Console.WriteLine("Invalid input! Please try again!");
                return;
            }

        
         
        }
    }
}
