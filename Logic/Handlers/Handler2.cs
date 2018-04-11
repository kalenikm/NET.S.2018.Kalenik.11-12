using System;

namespace Logic.Handlers
{
    public class Handler2
    {
        public void OnTimer(object sender, StopWatchEventArgs args)
        {
            Console.WriteLine("Handler2 => StopWatch class: {0}; TimePassed: {1};", sender.GetType(), args.PassedTime);
        }
    }
}