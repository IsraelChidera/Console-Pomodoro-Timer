﻿using System.Diagnostics;

namespace PomodoroTimer
{
    class Timer
    {
        private int _workTime;
        private int _restTime;

        public Timer(int workTime)
        {
            _workTime = workTime;
            //_restTime = restTime;
        }

        public Timer() { }

        public void workTime()
        {
            Stopwatch timer = new Stopwatch();

            if (_workTime > 0)
            {
                int workTimeInMinutes = _workTime * 1000*60;
                timer.Start();
                Thread.Sleep(workTimeInMinutes);
                Console.WriteLine(workTimeInMinutes);
                timer.Stop();
            }
            else
            {
                Console.WriteLine("Invalid time input. Input an integer");
            }

            TimeSpan ts = timer.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("Worktime completed");            
        }


    }
}