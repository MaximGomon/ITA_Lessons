using System;

namespace StartWithWindowsForms
{
    public class Subject : IComparable
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public int CompareTo(object obj)
        {
            if (obj is Subject)
            {
                if(this.Id == ((Subject)obj).Id)
                    return 0;
                if (this.Id > ((Subject)obj).Id)
                    return 1;
            }
            return -1;
        }

        public override bool Equals(object obj)
        {
            if (obj is Subject)
            {
                return this.Id == ((Subject) obj).Id;
            }
            else
            {
                return false;
            }
        }
    }
}