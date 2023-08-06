using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data
{
    public class Employee :EntityBase
    {
        public string Fname { set; get; }
        public string Lname { set; get; }
        public DateTime DateOfHiring { set; get; }
        public int Balance { set; get; }

        [ForeignKey("Department")]
        public int DepartmentId { set; get; }
        public Department Department { set; get; }
       
        [ForeignKey("Supervisior")]
       public int? SupervisiorId { set; get; } 
       public Employee Supervisior { set; get; }
    }
}
