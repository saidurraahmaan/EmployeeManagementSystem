using EmployeeManagement.Core.Domain.RepositoryInterfaces;
using EmployeeManagement.Core.DTO;
using EmployeeManagement.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceHistoryRepository _attendanceHistoryRepository;

        public AttendanceService(IAttendanceHistoryRepository attendanceHistoryRepository)
        {
            _attendanceHistoryRepository = attendanceHistoryRepository;
        }

        public Task<AttendanceResponse> AddAttendance(AttendanceAddRequest attendance)
        {
            return _attendanceHistoryRepository.AddAttendance(attendance);
        }
    }
}
