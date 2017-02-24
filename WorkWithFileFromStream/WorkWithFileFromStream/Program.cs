using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFileFromStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    string fileText = "It`s text for file";
            //    int i = MyFunk();
            //    File.WriteAllText(@"D:\12451\myFile.txt", fileText);
            //}
            //catch (DirectoryNotFoundException ex)
            //{
            //    Console.WriteLine("Directory for file is not found");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            DoSomething(1);
            //try
            //{
            //    int i = MyFunk();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine(new String('*', 50));
            //try
            //{
            //    int i = MySecondFunk();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Console.ReadLine();
        }

        private static int MyFunk()
        {
            try
            {
                DoSomething(1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return 0;
        }

        private static int MySecondFunk()
        {
            try
            {
                DoSomething(1);
            }
            catch (Exception ex)
            {
                throw;
            }
            return 0;
        }

        private static void DoSomething(int i)
        {
            //int a = int.Parse(Console.ReadLine());
            //int i = 2/a;
            i++;
            Console.WriteLine(i);
            DoSomething(i);
            //throw new NotImplementedException();
        }
    }
}
