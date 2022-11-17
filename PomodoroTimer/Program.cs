using System.Diagnostics;

namespace PomodoroTimer
{
    class Program
    {    

        static void Main(string[] args)
        {
            Console.WriteLine("Pomodoro app");

            //while (true) { }
            Console.WriteLine("Input work and rest time here (in minutes)");
            int workTime = Convert.ToInt32(Console.ReadLine());
            int restTime = Convert.ToInt32(Console.ReadLine());
            Timer pomo = new Timer(workTime, restTime);
            
            Console.WriteLine("Do you want to start a task /n (0/1)");
            int reply = Convert.ToInt32(Console.ReadLine());
            if(reply == 1)
            {
                Console.WriteLine("Focus on your task. You are doing great! /n You have {0} minutes to work", workTime);
                pomo.workTime();
                
                pomo.restTime();
                Console.WriteLine("Time to take a rest. \n you have {0} minutes to rest", restTime);
            }
            if (reply == 0)
            {
                Console.WriteLine("Ok!");
            }

            
            
        }

    }
}