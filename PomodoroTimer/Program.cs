using System.Diagnostics;

namespace PomodoroTimer
{
    class Program
    {    

        static void Main(string[] args)
        {
            Console.WriteLine("Pomodoro app");

            //while (true) { }
            Console.WriteLine("Input work time here (in minutes)");
            int workTime = Convert.ToInt32(Console.ReadLine());
            int restTime = Convert.ToInt32(Console.ReadLine());
            Timer pomo = new Timer(workTime, restTime);
            pomo.workTime();
            pomo.restTime();
            Console.WriteLine("Do you want to restart your timer /n (y/n)");
            string reply = Console.ReadLine();
            Console.WriteLine(reply);
            /*if (reply == "y")
            {
                
            }
            else if (reply == "n")
            {
                
            }*/
           

            /*pomo.workTime();*/
        }

    }
}