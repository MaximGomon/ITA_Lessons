using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        public string Name { get; set; }
        public string Type { get; set; }

        private void MovCarMove()
        {
            Console.WriteLine("I am moving...");
        }

        private string WhatDoYouWant(string iWantThis, int count)
        {
            return String.Format("{0} {1} {2}?", "Are you realy want", iWantThis, count);
        }
    }
}
