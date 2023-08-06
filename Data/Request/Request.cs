using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data
{
    public class Request :EntityBase
    {
        public DateTime From { set; get; }

        public DateTime To { set; get; }
        public string Reason { set; get; }
        public int State { set; get; }
        
        [ForeignKey("Employee")]
        public int EmployeeId { set; get; }
        public Employee Employee { set; get; }

        [ForeignKey("Department")]
        public int DepartmentId { set; get; }
        public Department Department { set; get; }  
    
    }
}
