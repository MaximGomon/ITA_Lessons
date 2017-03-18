using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ValueReferenceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now;
            var stop = DateTime.Now;

            var duration = stop - start;
            int total = (int)duration.TotalSeconds;

            Stopwatch st = new Stopwatch();
            st.Start();
            st.Stop();
            double totalsec = st.Elapsed.TotalSeconds;

            Console.ForegroundColor = ConsoleColor.Yellow;

            ReferenceTypeClass item = new ReferenceTypeClass();
            ReferenceTypeClass secondItem = new ReferenceTypeClass();
            ReferenceTypeClass thirdItem = new ReferenceTypeClass();

            secondItem = item;
            secondItem.Id = 4;
            thirdItem = item;

            ChangeId(thirdItem);

            SomeSayClass sayItem = new SomeSayClass();

            List<ISayHello> sayList = new List<ISayHello>();
            sayList.Add(secondItem);
            sayList.Add(sayItem);
            sayList.Add(new ValueTypeClass());

            foreach (ISayHello sayHello in sayList)
            {
                sayHello.Say();
            }

            Console.WriteLine(new string('=', 5));
            Console.WriteLine(item.Id);
            Console.WriteLine(secondItem.Id);
            Console.WriteLine(thirdItem.Id);
            Console.WriteLine(new string('=', 5));
            Console.WriteLine();

            ValueTypeClass firstStruct = new ValueTypeClass();
            ValueTypeClass secondStruct = new ValueTypeClass();
            secondStruct = firstStruct;
            firstStruct.Id = 8;

            Console.WriteLine(new string('=', 5));
            Console.WriteLine(firstStruct.Id);
            Console.WriteLine(secondStruct.Id);
            Console.WriteLine(new string('=', 5));
           // Console.ReadLine();
        }

        public static void SayHello(ISayHello objectToSay)
        {
            objectToSay.Say();
        }

        public static void ChangeId(ReferenceTypeClass element)
        {
            element = new ReferenceTypeClass();
            element.Id = 9;
        }
    }

    public interface ISayHello
    {
        void Say();
    }

    public class ReferenceTypeClass : ISayHello
    {
        public int Id { get; set; }
        public void Say()
        {
            Console.WriteLine("Hello");
        }
    }

    public class SomeSayClass : ISayHello
    {
        public void Say()
        {
            Console.WriteLine("SomeSayClass say Hello");
        }
    }

    public struct ValueTypeClass : ISayHello
    {
        public int Id { get; set; }
        public void Say()
        {
            Console.WriteLine("ValueType say Hello");
        }
    }
}
