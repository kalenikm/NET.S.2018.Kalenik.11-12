using System;

namespace Logic
{
    public class Handler3
    {
        public void OnTimer(object sender, StopWatchEventArgs args)
        {
            Console.WriteLine("Handler3 => StopWatch class: {0}; TimePassed: {1};", sender.GetType(), args.PassedTime);
        }
    }
}