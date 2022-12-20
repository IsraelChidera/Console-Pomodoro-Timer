using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    internal class Application
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\nInput work time here");
                    Console.Write("[In minutes]: ");
                    int workTime = Convert.ToInt32(Console.ReadLine());
                    if (workTime < 1)
                    {
                        Utility.Error("Invalid work time. Input a positive integer");
                        Console.WriteLine("\nInput work time here");
                        Console.Write("[In minutes]: ");
                        workTime = Convert.ToInt32(Console.ReadLine());
                    }
                    

                    Console.WriteLine("\nInput rest time here (in minutes)");
                    Console.Write("[In minutes]: ");
                    int restTime = Convert.ToInt32(Console.ReadLine());
                    if (restTime < 1)
                    {
                        Utility.Error("Invalid rest time.Input a positive integer");
                        Console.WriteLine("\nInput rest time here");
                        Console.Write("[In minutes]: ");
                        restTime = Convert.ToInt32(Console.ReadLine());
                    }
                   
                    Timer pomo = new(workTime, restTime);

                    Utility.SelectPrompt("\tDo you want to start this task \n \tType 0 if NO \n \tType 1 if YES");

                    int reply = Convert.ToInt32(Console.ReadLine());
                    if (reply == 1)
                    {
                        Console.Clear();
                        Utility.OnGoing($"\nFocus on your task. You are doing great! \n You have {workTime} minutes to work");
                        pomo.WorkTime();
                        Console.WriteLine("You have finished your task. It is now time to rest");

                        Console.Clear();
                        Utility.OnGoing($"Time to take a rest. \n you have {restTime} minutes to rest");
                        pomo.RestTime();

                        Utility.Success("You have sucessfully finished your task");

                        Utility.SelectPrompt("\tDo you want to start another task \n\t0: if NO \n\t1: if YES");
                        int response = Convert.ToInt32(Console.ReadLine());
                        if (response == 1)
                        {
                            Run();
                        }
                        else if (response == 0)
                        {
                            Console.WriteLine("\nThank you for staying with us thus far\nWe hope to see you again");
                            break;
                        }
                        else
                        {
                            Utility.Error("\nInvalid input...\nTry again");
                        }
                        
                    }
                    if (reply == 0)
                    {
                        Console.WriteLine("\n\nOk! Come back when you are ready to work\nThank you . . . ");
                        break;
                    }

                }
                catch (FormatException e)
                {
                    Utility.Error($"\n{e.Message}");                    
                }
                catch (Exception e)
                {
                    Utility.Error($"\n{e.Message}");
                }

            }

        }
    }
}
