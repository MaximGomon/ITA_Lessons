using System;

namespace TypeMembrs
{
    public class People
    {
        //field (access mod type name)
        public int Age;
        //avto property (access mod type name {access mod (allow) get; access mod (allow) set;})
        public string FirstName { get; set; }
        //private field (access mod, type, name)
        private string _lastName;
        //property (access mod type name 
        //{access mod (allow) get {method body} access mod (allow) set {method body}})
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        //property (access mod type name {access mod (allow) get {method body} access mod (allow)})
        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
        //constructor (access mod TypeName (parameters))
        public People()
        {
        }
        //constructor (access mod TypeName (parameters))
        public People(int age)
        {
            Age = age;
        }
        //method/function (access mod type Name(parameters) {method body})
        public int CalculateYearOfBirth()
        {
            return DateTime.Now.Year - Age;
        }
        //ovveride method
        public override string ToString()
        {
            return $"Name: {FullName} Age: {Age}";
        }
        //static method
        public static void DisplayDescription()
        {
            Console.WriteLine("This is description of class People!");
        }
    }
}