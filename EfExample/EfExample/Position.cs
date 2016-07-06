using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfExample
{
    public class Position
    {
        public Position()
        {
            Id = Guid.NewGuid();
        }
        //Market this field as primary key
        [Key]
        public Guid Id { get; set; }
        //Create unique constraint for Code field
        [Index(IsUnique = true)]
        public int Code { get; set; }
        //Set max length on Name to 50 characters (nvarchar(50))
        [MaxLength(50)]
        public string Name { get; set; }
    }
}