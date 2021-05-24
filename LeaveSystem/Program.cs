using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeaveSystem
{
    class Program
    {
        static List<string> actions = new List<string>()
            { "Leave Request (type 1)", "Login as Admin (type 2)", "exit app (type 3)" };

        static List<string> LeaveType = new List<string>()
        { "Birthday Leave", "Sick Leave", "Maternity Leave", "Faternity Leave", "Vacation Leave" };

        static void Main(string[] args)
        {


            Console.WriteLine("\n \a \a \a \a * * Welcome! * * ");
            Console.WriteLine("\n * Employee Leave Management System *\n \a \a < Enter any key to Proceed > ");
            Console.ReadKey();


            for (int useraction = GetUserAction();
     useraction != actions.IndexOf("exit app (type 3)");
     useraction = GetUserAction())
            {
                switch (useraction)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(LeaveRequest());
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(Login());
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid! Try again.");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Application exiting...");
            Console.ReadKey();

        }


        public static string Login()
        {

            Console.WriteLine("\a \a * Login as Admin *");
            int logCount = 0;

            for (int i = 0; i < 5; i++)
            {
                admin user = new admin();
                Console.Write(" \n Username: ");
                user.Username = Console.ReadLine();

                admin pass = new admin();
                Console.Write("\n Password: ");
                pass.Password = Console.ReadLine();

                if (user.Username != "admin" 
                    || pass.Password == "pass")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Your username or password is incorrect! \n Please try again.");
                    logCount++;
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
            

            Console.WriteLine("\a \a* * Leave Request * *");
            Console.WriteLine("\n \n Please fill out this form.");

            Console.WriteLine(GetLeaveType());

            LeaveRequest Id = new LeaveRequest();
            Console.WriteLine("Employee Id number: \n");
            Id.EmployeeIdNumber = Console.ReadLine();

            LeaveRequest EmployeeName = new LeaveRequest();
            Console.WriteLine("Name: \n");
            EmployeeName.name = Console.ReadLine();

            LeaveRequest EmpBirthDay = new LeaveRequest();
            Console.WriteLine("Birthday: \n");
            EmpBirthDay.Birthday = Console.ReadLine();

            LeaveRequest LvDay = new LeaveRequest();
            Console.WriteLine("How many days are you going for a leave? \n");
            LvDay.LeaveDay = Console.ReadLine();

            LeaveRequest LvReason = new LeaveRequest();
            Console.WriteLine("Please put your valid reason why you were applying for a leave. \n");
            LvReason.Reason = Console.ReadLine();


            Console.WriteLine("\n \n \n * * Please review the data you've enter. * * ");
            Console.WriteLine($"I am {EmployeeName.name} born in {EmpBirthDay.Birthday} with Employee Id number {Id.EmployeeIdNumber}. \n I am applying for a {LvDay.LeaveDay} day/s of leave because {LvReason.Reason}. \n Thank you!");
            return "";
        }


        static int GetUserAction()
        {
            ShowOptions();
           Console.WriteLine("ACTION: ");   
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

        static void ShowLeaveType()
        {
            Console.WriteLine("Choose any of the following options. ");

            foreach (var LeaveType in LeaveType)
            {
                Console.WriteLine(LeaveType);
            }
        }
        static string GetLeaveType()
        {
            ShowLeaveType();
                Console.Write("Choose your Leave Type: ");
                return Console.ReadLine();
        }

    }
}





    


