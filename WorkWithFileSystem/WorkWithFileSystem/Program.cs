using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace WorkWithFileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            try
            {
                var list = new List<string>
                {
                    "It`s first line",
                    "it`s second line"
                };
                Directory.CreateDirectory("folder");
                File.WriteAllText(@"folder\MyFirstFile.txt", "It`s file text");
                File.WriteAllLines(@"folder\MySecondFile.txt", list);

                File.AppendAllLines(@"MyFile.txt", list);
                File.AppendAllText(@"MyFile.txt", "Hello");

                //Ctrl+R+M - Extract method
                //Ctrl+K+C - comment all selected lines
                //Ctrl+K+U - uncomment all selected lines

                GetFilesFromCurrentDirectory();

                Directory.SetCurrentDirectory(Directory.GetCurrentDirectory() + @"\folder");
                Console.WriteLine();
                GetFilesFromCurrentDirectory();

            }
            catch (DirectoryNotFoundException dirException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Directory not found {dirException.Message}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End of work");
            Console.ReadKey();
        }

        private static void GetFilesFromCurrentDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);
            DisplayFilesInDirectory(currentDirectory);
        }

        private static void DisplayFilesInDirectory(string currentDirectory)
        {
            var filesInDirectory = Directory.GetFiles(currentDirectory);
            string stringToDisplay = string.Join(Environment.NewLine, filesInDirectory);
            Console.WriteLine(stringToDisplay);
        }
    }
}
