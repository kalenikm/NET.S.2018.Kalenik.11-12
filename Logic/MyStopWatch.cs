using System;
using System.Threading;

namespace Logic
{
    public delegate void StopWatchEventHandler(object sender, StopWatchEventArgs args);
    public class MyStopWatch
    {
        public event StopWatchEventHandler Event;

        public void Start(TimeSpan time)
        {
            Thread.Sleep(time);
            Event?.Invoke(this, new StopWatchEventArgs(time));
        }
    }
}