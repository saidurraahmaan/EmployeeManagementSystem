using EmployeeManagement.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Domain.RepositoryInterfaces
{
    public interface IAttendanceHistoryRepository
    {
        Task<AttendanceHistory> AddAttendance(AttendanceHistory attendanceHistory);
        
    }
}
