using System.Diagnostics;

namespace PomodoroTimer
{
    class Program
    {    

        static void Main(string[] args)
        {
            Console.WriteLine("Pomodoro app");

            while (true) {
                Console.WriteLine("Input work time here (in minutes)");
                int workTime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input rest time here (in minutes)");
                int restTime = Convert.ToInt32(Console.ReadLine());
                Timer pomo = new Timer(workTime, restTime);

                Console.WriteLine("****************************************");
                Console.WriteLine("Do you want to start a task \n \tType 0 if reply is NO \n \tType 1 if YES");
                Console.WriteLine("****************************************");

                int reply = Convert.ToInt32(Console.ReadLine());
                if (reply == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nFocus on your task. You are doing great! \n You have {0} minutes to work", workTime);
                    pomo.workTime();
                    Console.ResetColor();
                    
                    Console.WriteLine("You have finished your task. It is now time to rest");

                    pomo.restTime();
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Time to take a rest. \n you have {0} minutes to rest", restTime);
                    Console.ResetColor();
                    Console.WriteLine("\n\n\n You are done resting.");
                }
                if (reply == 0)
                {
                    Console.WriteLine("\n\nOk! Come back when you are ready to work");
                    break;
                }
            }
            
                       
        }

    }
}