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
                Console.WriteLine("   Session 3 - press key [3] ");
                Console.WriteLine("   Session 4 - press key [4] ");
                Console.WriteLine("   Session 5 - press key [5] ");
                Console.WriteLine("   Quit      - press key [Q] ");

                userAction = Console.ReadKey();

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"----- Executing action {userAction.Key} -----");
                if(userAction.Key == ConsoleKey.D1)
                    sessions.ExecuteTransactions();
                if(userAction.Key == ConsoleKey.D2)
                    sessions.ExecuteArrays();
                if(userAction.Key == ConsoleKey.D3)
                    sessions.ExecuteList();
                if(userAction.Key == ConsoleKey.D4)
                    sessions.ExecuteAddingElementsToList();
                if(userAction.Key == ConsoleKey.D5)
                    sessions.ExecuteRemoveFromList();
            }
            while(userAction.Key != ConsoleKey.Q);
            
        }
    }
}
                