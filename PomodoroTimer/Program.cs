using System.Diagnostics;

namespace PomodoroTimer
{
    class Program
    {    

        static void Main(string[] args)
        {
            Timer pomo = new Timer(1);
            pomo.workTime();
        }

    }
}