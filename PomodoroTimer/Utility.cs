using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    internal class Utility
    {
        public static void UI()
        {            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("\t\tFocus Assist Pomodoro app\n\t\t... Work and Enjoy");            
            Console.WriteLine("***************************************************************************");
            Console.ResetColor();
        }

        public static string Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            return message;
        }

        public static string OnGoing(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
            return message;
        }

        public static string Success(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
            return message;
        }

        public static string SelectPrompt(string message)
        {
            Console.WriteLine("\n*******************************************");
            Console.WriteLine(message);
            Console.WriteLine("*******************************************\n");
            return message;
        }
    }
}
