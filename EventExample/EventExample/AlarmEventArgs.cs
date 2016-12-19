using System;

namespace EventExample
{
    public class AlarmEventArgs : EventArgs
    {
        public AlarmEventArgs(bool isDelay, int numberOfRings)
        {
            IsDelay = isDelay;
            NumberOfRings = numberOfRings;
        }

        public int NumberOfRings { get; }
        public bool IsDelay { get; }

        public string AlarmText
        {
            get
            {
                if (IsDelay)
                {
                    return ("Wake Up!!! Delay time is over.");
                }
                return ("Wake Up!");
            }
        }
    }
}