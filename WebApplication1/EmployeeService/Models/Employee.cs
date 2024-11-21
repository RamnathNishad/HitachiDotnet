using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeService.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ecode { get; set; }

        [Column("Empname")]
        public string Ename { get; set; }
        public int Salary { get; set; }
        public int Deptid { get; set; }
        //public string City {  get; set; }
    }
}
