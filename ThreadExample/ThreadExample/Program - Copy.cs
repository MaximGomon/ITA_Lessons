using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample
{
    class Program
    {
        static async void  MyTask()
        {
            Console.WriteLine("MyTask() №{0} запущен", Task.CurrentId);

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask №{0} подсчет равен {1}", Task.CurrentId, count);
            }

            await Task.Run(() => GetCount(10));
            Console.WriteLine("MyTask() №{0} завершен", Task.CurrentId);
        }

        static void GetCount(int count)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"This is async result {count}");
        }
        static void Main()
        {
            Console.WriteLine("Основной поток запущен");
            var tf = new TaskFactory();
            //var task1 = tf.StartNew(MyTask);

            var task2 = Task.Factory.StartNew(MyTask);
            Task.WaitAll(task2);
            task2.ContinueWith(Task<int>.Run(() => GetCount(4)));
            //Task task1 = new Task(MyTask);
            //Task task2 = new Task(MyTask);
            //var t = Task.Run(() => MyTask());
            //Thread.Sleep(1000);
            //// Запустить задачу
            //task1.Start();
            //Thread.Sleep(1000);
            //task2.Start();
            //Thread.Sleep(1000);
            //Console.WriteLine(t1);

            //for (int i = 0; i < 60; i++)
            //{
            //    Console.WriteLine(".");
            //    Thread.Sleep(100);
            //}

            Console.WriteLine("Основной поток завершен");
            Console.ReadLine();
        }
    }
}
