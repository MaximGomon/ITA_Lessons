using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace WF2
{
    public class Cross : Bike
    {
        public Cross(int id) : base(id)
        {
        }
        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3}", Id, Name, Size, BikeType.Cross);
        }

        public static bool TryParse(string source, out Cross result)
        {
            result = null;
            List<string> splitString = source.Split(';').ToList();
            try
            {
                int id = splitString[0].GetInt();
                if (id == -1)
                {
                    throw new Exception("Cannot parse id of bike");
                }
                else
                {
                    int size = splitString[2].GetInt();
                    if (size == -1)
                    {
                        throw new Exception("Cannot parse size of bike");
                    }
                    result = new Cross(id)
                    {
                        Size = size,
                        Name = splitString[1]
                    };
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}