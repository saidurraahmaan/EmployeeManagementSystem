using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Domain.Entities
{
    public class AttendanceHistory
    {
        public int RecId { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; } 
        public DateOnly Date { get; set; }
        public TimeOnly CheckInTime { get; set; }
        public TimeOnly CheckOutTime { get; set; }

    }
}
