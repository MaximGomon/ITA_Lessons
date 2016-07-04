using System;

namespace AdoNetSample
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {1} {3} {1} {4} {1} {5}", Id, "\t", Name,
                Salary, Email, BirthDate.ToShortDateString());
        }
    }
}