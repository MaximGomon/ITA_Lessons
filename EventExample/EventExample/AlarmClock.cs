using System;

namespace EventExample
{
    public delegate void AlarmEventHandler(AlarmClock sender, AlarmEventArgs e);

    public class AlarmClock
    {
        private int _numberOfRings = 0;
        public bool IsStop { get; set; }
        public bool IsDelay { get; set; }

        public event AlarmEventHandler AlarmEvent;

        protected virtual void OnAlarm(AlarmEventArgs e)
        {
            //AlarmEventHandler handler = AlarmEvent;
            //if (handler != null)
            //{
                AlarmEvent(this, e);
            //}
        }

        // This alarm clock does not have 
        // a user interface. 
        // To simulate the alarm mechanism it has a loop 
        // that raises the alarm event at every iteration 
        // with a time delay of 300 milliseconds, 
        // if snooze is not pressed. If snooze is pressed, 
        // the time delay is 1000 milliseconds. 
        public void Start()
        {
            while (true)
            {
                _numberOfRings++;
                if (IsStop)
                {
                    break;
                }
                else
                {
                    if (IsDelay)
                    {
                        Console.WriteLine("Delay sleep");
                        System.Threading.Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("Sleep");
                        Console.Beep();
                        System.Threading.Thread.Sleep(300);
                    }
                    OnAlarm(new AlarmEventArgs(IsDelay, _numberOfRings));
                }
            }
        }
    }
}