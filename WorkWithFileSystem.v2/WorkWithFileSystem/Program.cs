using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkWithFileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            bool isExit = false;
            while (!isExit)
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                Console.Write($"{currentDirectory}>");
                
                string command = Console.ReadLine().ToLower();
                string[] splitCommand = command.Split(' ');

                command = splitCommand[0];

                switch (command)
                {
                    case "cd..":
                        string parrentDirectory = Directory.GetParent(currentDirectory).FullName;
                        Directory.SetCurrentDirectory(parrentDirectory);
                        break;
                    case "cd\\":
                        string rootDirectory = Directory.GetDirectoryRoot(currentDirectory);
                        Directory.SetCurrentDirectory(rootDirectory);
                        break;
                    case "cd":
                        if (splitCommand.Length > 1)
                        {
                            string newDirectory = splitCommand[1];
                            if (Directory.Exists(newDirectory))
                                Directory.SetCurrentDirectory(newDirectory);
                            else
                                DisplayError("Entered wrong command!");
                        }
                        break;
                    case "dir":
                        Dir(Directory.GetCurrentDirectory());
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "exit":
                        isExit = true;
                        break;
                    case "mf":
                        if (splitCommand.Length > 1)
                        {
                            string fileName = splitCommand[1];
                            Console.WriteLine();
                            Console.Write("Please write file text (for end press \'Enter\')");
                            string fileText = Console.ReadLine();
                            File.WriteAllText(fileName, fileText);
                        }
                        break;
                    case "vf":
                        if (splitCommand.Length > 1)
                        {
                            string fileName = splitCommand[1];
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(new string('-', 30));
                            Console.WriteLine(File.ReadAllText(fileName));
                            Console.WriteLine(new string('-', 30));
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        break;
                    default:
                        DisplayError("Entered wrong command!");
                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Program will be exit...");
            Thread.Sleep(1000);
        }

        private static void DisplayError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        private static void Dir(string dir)
        {
            Console.WriteLine(new string('-', 30));

            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var directory in Directory.GetDirectories(dir))
            {
                DirectoryInfo currentDir = new DirectoryInfo(directory);
                Console.WriteLine(currentDir.Name);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var file in Directory.GetFiles(dir))
            {
                FileInfo fileInfo = new FileInfo(file);
                Console.WriteLine(fileInfo.Name);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', 30));
        }
    }
}
