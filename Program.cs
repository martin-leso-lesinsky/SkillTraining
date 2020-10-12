using System;

namespace SkillTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo userAction;            
            Sessions sessions = new Sessions();
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Select session:");
                Console.WriteLine("   Session 1 - press key [1] ");
                Console.WriteLine("   Session 2 - press key [2] ");
                Console.WriteLine("   Quit      - press key [Q] ");

                userAction = Console.ReadKey();

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"----- Executing action {userAction.Key} -----");
                if(userAction.Key == ConsoleKey.D1)
                    sessions.ExecuteTransactions();
                if(userAction.Key == ConsoleKey.D2)
                    sessions.ExecuteArrays();
            }
            while(userAction.Key != ConsoleKey.Q);
        }
    }
}
