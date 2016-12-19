using System;

namespace EventExample
{
    public class WakeMeUp
    {
        public static void AlarmRang(AlarmClock sender, AlarmEventArgs e)
        {
            Console.WriteLine(e.AlarmText);

            if (!e.IsDelay)
            {
                if (e.NumberOfRings % 5 == 0)
                {
                    Console.WriteLine(" Let alarm ring? Enter Y");
                    Console.WriteLine(" Press delay? Enter N");
                    Console.WriteLine(" Stop Alarm? Enter Q");
                    string input = Console.ReadLine();

                    //if(input == "Y" || input == "y")

                    //if(String.Equals(input, "Y", StringComparison.InvariantCultureIgnoreCase))

                    if (input.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                    {
                        return;
                    }
                    else if (input.Equals("N", StringComparison.InvariantCultureIgnoreCase))
                    {
                        sender.IsDelay = true;
                        return;
                    }
                    else
                    {
                        sender.IsStop = true;
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine(" Let alarm ring? Enter Y");
                Console.WriteLine(" Stop Alarm? Enter Q");
                String input = Console.ReadLine();
                if (input.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                {
                    return;
                }
                else
                {
                    sender.IsStop = true;
                    return;
                }
            }
        }
    }
}