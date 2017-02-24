using System;
using System.Collections.Generic;
using System.Linq;

namespace JsonFileReading
{
    public static class Extensions
    {
        public static string GetLastAfterPoint(this string source)
        {
            var splitString = source.Split('.');
            var i = 9;
            return splitString.Last() ?? String.Empty;
        }

        public static List<T> CreateList<T>()
        {
            return new List<T>();
        } 
    }
}