using System;
using Logic;
using Logic.Handlers;

namespace ConsoleUI
{
    class Program
    {
        static void Main()
        {
            MyStopWatch stopwatch = new MyStopWatch();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();
            Handler3 handler3 = new Handler3();
            stopwatch.Event += handler1.OnTimer;
            stopwatch.Event += handler2.OnTimer;
            stopwatch.Event += handler3.OnTimer;
            stopwatch.Start(new TimeSpan(0,0,5));
        }
    }
}
