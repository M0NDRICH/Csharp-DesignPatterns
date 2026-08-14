using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State.Overkill
{
    internal class Stopwatch
    {
        private bool IsRunning { get; set; } = false;

        public void Click()
        {
            if (IsRunning)
            {
                IsRunning = false;
                Console.WriteLine("Stopped");
            }
            else
            {
                IsRunning = true;
                Console.WriteLine("Running");
            }
        }
    }
}
