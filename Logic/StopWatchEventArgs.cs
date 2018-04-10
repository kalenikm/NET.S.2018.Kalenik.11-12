using System;

namespace Logic
{
    public class StopWatchEventArgs : EventArgs
    {
        public StopWatchEventArgs(TimeSpan time)
        {
            PassedTime = time;
        }

        public TimeSpan PassedTime { get; }
    }
}