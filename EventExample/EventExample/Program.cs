using System;

namespace EventExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock();

            clock.AlarmEvent += WakeMeUp.AlarmRang;
            clock.AlarmEvent -= WakeMeUp.AlarmRang;
            //clock.AlarmEvent += ClockOnAlarmEvent;
            //clock.AlarmEvent += SecondClockOnAlarmEvent;
            clock.Start();
        }

        private static void SecondClockOnAlarmEvent(AlarmClock sender, AlarmEventArgs alarmEventArgs)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This is my RED alarm!");
            Console.ResetColor();
        }

        private static void ClockOnAlarmEvent(AlarmClock sender, AlarmEventArgs alarmEventArgs)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This is my alarm!");
            Console.ResetColor();
        }
    }
}
