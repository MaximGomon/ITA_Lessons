using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllImportExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var driveType = ImportedFunctions.GetDriveType("D:\\");
            Console.WriteLine("Drive Type is: {0}", driveType);

            var systemVersion = ImportedFunctions.GetVersion();
            Console.WriteLine("System version is: {0}", systemVersion);
            Console.ReadLine();
        }
    }
}
