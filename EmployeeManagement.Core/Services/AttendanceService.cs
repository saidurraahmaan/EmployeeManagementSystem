using EmployeeManagement.Core.Domain.RepositoryInterfaces;
using EmployeeManagement.Core.DTO;
using EmployeeManagement.Core.ServiceInterfaces;

namespace EmployeeManagement.Core.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceHistoryRepository _attendanceHistoryRepository;

        public AttendanceService(IAttendanceHistoryRepository attendanceHistoryRepository)
        {
            _attendanceHistoryRepository = attendanceHistoryRepository;
        }

        public Task<AttendanceResponse> AddAttendance(AttendanceAddRequest employee)
        {
            throw new NotImplementedException();
        }
    }
}
