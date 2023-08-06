using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Infrastructure.Dtos
{
    public class RequestDto
    {
        public DateTime From { set; get; }

        public DateTime To { set; get; }
        public string Reason { set; get; }

        public int State { set; get; }
        public int EmployeeId { set; get; }
    }
}
