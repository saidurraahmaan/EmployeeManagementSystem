using EmployeeManagement.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.ServiceInterfaces
{
    public interface IAttendanceService
    {
        Task<AttendanceResponse> AddAttendance(AttendanceAddRequest employee);
    }
}
