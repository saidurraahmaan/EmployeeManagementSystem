using EmployeeManagement.Core.DTO;

namespace EmployeeManagement.Core.ServiceInterfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeResponseDetails> AddEmployee(EmployeeAddRequest employee);
        Task<EmployeeResponseDetails> GetEmployeeById(int employeeId);
        Task<AttendanceResponse> GetEmployeeAttendanceById(int employeeId);

    }
}
