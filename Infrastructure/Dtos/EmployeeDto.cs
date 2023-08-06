using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Dtos
{
    public class EmployeeDto
    {
        public string Fname { set; get; }
        public string Lname { set; get; }
        public DateTime DateOfHiring { set; get; }
        public int DepartmentId { set; get; }
        public int? SupervisiorId { set; get; }

    }
}
