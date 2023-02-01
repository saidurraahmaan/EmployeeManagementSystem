using EmployeeManagement.Core.DTO;

namespace EmployeeManagement.Core.ServiceInterfaces
{
    public interface IAttendanceService
    {
        Task<AttendanceResponse> AddAttendance(AttendanceAddRequest employee);
    }
}
