using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{

    [Table("Employee")]
    public class Employee
    {

        [Key]
        [Column("Id", TypeName = "int")]

        public int? id { get; set; }



        [Column("EmployeeName")]
        public string? EmployeeName { get; set; }


        [Column("Designation")]
        public string? Designation { get; set; }
    }



}
