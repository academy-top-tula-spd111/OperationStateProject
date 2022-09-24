using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationStateProject
{
    internal class Timer
    {
        public int Hours { set; get; }
        public int Minutes { set; get; }
        public int Seconds { set; get; }
    }

    class StopWatch
    {
        public int Seconds { set; get; }

        public StopWatch(int seconds = 0)
        {
            Seconds = seconds;
        }

        public static implicit operator StopWatch(int number)
        {
            return new StopWatch(number);
        }

        public static explicit operator int(StopWatch stopWatch)
        {
            return stopWatch.Seconds;
        }

        public static explicit operator StopWatch(Timer timer)
        {
            return new StopWatch(timer.Hours * 3600 + timer.Minutes * 60 + timer.Seconds);
        }

        public static implicit operator Timer(StopWatch stopWatch)
        {
            return new Timer()
            {
                Hours = stopWatch.Seconds / 3600,
                Minutes = (stopWatch.Seconds % 3600) / 60,
                Seconds = stopWatch.Seconds % 60
            };
        }
    }
}
