using EmployeeManagement.Core.Domain.Entities;

namespace EmployeeManagement.Core.Domain.RepositoryInterfaces
{
    public interface IAttendanceHistoryRepository
    {
        Task<AttendanceHistory> AddAttendance(AttendanceHistory attendanceHistory);
        Task<List<AttendanceHistory>> GetAttendanceHistoryByEmployeeId(int id);

    }
}
