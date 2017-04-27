using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample
{
    public class Employee
    {
        public Employee()
        {
            Id = Guid.NewGuid();
        }
        //Market this field as primary key
        [Key]
        public Guid Id { get; set; }
        //Set max and min length with validation error message
        [MinLength(3, ErrorMessage = "Length must be more that 5 characters")]
        [MaxLength(100, ErrorMessage = "Length must be less that 100 characters")]
        [Required]
        public string FirstName { get; set; }
        [MinLength(3, ErrorMessage = "Length must be more that 5 characters")]
        [MaxLength(100, ErrorMessage = "Length must be less that 100 characters")]
        [Required]
        public string LastName { get; set; }
        //Set field as not null
        [Required]
        public double Salary { get; set; }
        //Set db type to datetime2, because default is datetime
        //[Column(TypeName = "datetime2")]
        [Required]
        public DateTime BirthDate { get; set; }
        //Make linked entity as virtual for lazy loading works
        public virtual Employee Manager { get; set; }
        //Set field as not null
        [Required]
        public Position Position { get; set; }
        [Required]
        public Department Department { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}{7}Birthdate: {2}{7}Position: {3}{7}Department: {4}{7}Salary: {5}{7}Manager: {6} {8}{7}", 
                FirstName, LastName, BirthDate.ToShortDateString(), Position.Name, Department.Name, Salary, 
                Manager == null ? String.Empty : Manager.FirstName, Environment.NewLine,
                Manager == null ? String.Empty : Manager.LastName);
        }
    }
}