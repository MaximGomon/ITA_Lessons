using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetAssembly(typeof (Car));
            Console.Write("This is assemly where class Car defined: ");
            Console.WriteLine(assembly.FullName + Environment.NewLine);
            Console.WriteLine("This is all types defined in current assemly:");
            foreach (var definedType in assembly.DefinedTypes)
            {
                Console.WriteLine(definedType.FullName);
            }
            Console.WriteLine();
            foreach (var definedType in assembly.DefinedTypes)
            {
                Console.WriteLine("This all methods which are implemented in class {0}", definedType.FullName);
                Console.WriteLine();
                var methods = definedType.DeclaredMethods.Where(x => !x.IsSpecialName);
                foreach (var declaredMethod in methods)
                {
                    string access = !declaredMethod.IsPrivate ? "public" : "private";

                    string parameters = String.Empty;
                    foreach (var item in declaredMethod.GetParameters())
                    {
                        if (declaredMethod.GetParameters().ToList().IndexOf(item) !=
                            declaredMethod.GetParameters().Length - 1)
                        {
                            parameters += item.ParameterType.Name + " " + item.Name + ", ";
                        }
                        else
                        {
                            parameters += item.ParameterType.Name + " " + item.Name;
                        }

                    }
                    Console.WriteLine("{0}({1}):{2}\t{3}", declaredMethod.Name, parameters,
                        declaredMethod.ReturnType.Name, access);
                }
                Console.WriteLine();
                foreach (var declaredMethod in definedType.DeclaredMethods)
                {
                    if (declaredMethod.Name == "MovCarMove")
                    {
                        Console.WriteLine();
                        Console.WriteLine("At now we try to invoke method \"MovCarMove\" of current type:");
                        declaredMethod.Invoke(new Car(), null);
                    }
                    if (declaredMethod.Name == "WhatDoYouWant")
                    {
                        Console.WriteLine();
                        Console.WriteLine("At now we try to invoke method \"WhatDoYouWant\" of current type:");
                        Console.WriteLine(declaredMethod.Invoke(new Car(), new[] { (object)"All the things", (object)4 }));
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
