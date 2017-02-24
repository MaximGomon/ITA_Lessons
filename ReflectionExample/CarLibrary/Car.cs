using System;
using System.Collections.Generic;

namespace CarLibrary
{
    public class Car
    {
        public string Name { get; set; }
        public string Type { get; set; }

        private void MovCarMove()
        {
            int i = 0;
            Console.WriteLine("I am moving...");
        }

        private string WhatDoYouWant(string iWantThis, long count)
        {
            string s = "hvfyfiys";
            List<float> myList = new List<float>();
            return String.Format("{0} {1} {2}?", "Are you realy want", iWantThis, count);
        }
    }
}
