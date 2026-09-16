using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFproject.Models
{
    [Table("Customers")]
    internal class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        [Column (TypeName = "varchar(100)")]

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string image {  get; set; }

    }
}
