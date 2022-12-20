using System.Diagnostics;

namespace PomodoroTimer
{
    public partial class Timer
    {
        private int _workTime;
        private int _restTime;        

        public Timer(int workTime, int restTime)
        {
            _workTime = workTime;
            _restTime = restTime;            
        }

        public Timer() { }

        public void WorkTime()
        {
            
            Stopwatch timer = new Stopwatch();
            
            if (_workTime > 0)
            {                
                int workTimeInSeconds = _workTime * 60;
                timer.Start();
                for (int i = 0; i < workTimeInSeconds; i++)
                {
                    Console.Write("Work time covered: ");
                    Console.WriteLine($"{i} seconds");
                    Thread.Sleep(1000);
                    //Console.Clear();
                }                                
                timer.Stop();
            }
            else
            {
                Console.WriteLine("Invalid time input. Input an integer");
            }

            TimeSpan ts = timer.Elapsed;
            string elapsedTime = String.Format("\n{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("Summary of work time: " + elapsedTime);
            Utility.Success("Work time completed");      
        }

        public void RestTime()
        {
            Stopwatch timer = new Stopwatch();

            if (_restTime > 0)
            {               
                int restTimeInSeconds = _restTime * 60;
                timer.Start();
                for (int i = 0; i < restTimeInSeconds; i++)
                {
                    Console.Write("Rest time covered: ");
                    Console.WriteLine($"{i} seconds");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                timer.Stop();
            }
            else
            {
                Console.WriteLine("Invalid time input. Input an integer");
            }

            TimeSpan ts = timer.Elapsed;
            string elapsedTime = String.Format("\n{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("Summary of the rest time: " + elapsedTime);
            Utility.Success("Rest time completed");
        }

    }
}
