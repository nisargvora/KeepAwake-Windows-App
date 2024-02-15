using System;
using System.Threading;
using System.Windows.Forms;

namespace KeepAwake;

class Program
{
    static void Main(string[] args)
    {
        // Set up a timer to trigger every minute
        System.Threading.Timer timer = new System.Threading.Timer(OnTimerCallback, null, TimeSpan.Zero, TimeSpan.FromMinutes(1));

        // Keep the program running
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

        // Dispose of the timer when done
        timer.Dispose();
    }

    static void OnTimerCallback(object state)
    {
        // Simulate pressing F15 key
        SendKeys.SendWait("{F15}");
        Console.WriteLine("F15 key pressed at: " + DateTime.Now);
    }
}
