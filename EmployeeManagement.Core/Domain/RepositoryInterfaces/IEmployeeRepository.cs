using EmployeeManagement.Core.Domain.Entities;

namespace EmployeeManagement.Core.Domain.RepositoryInterfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> GetEmployeeById(int id);
        Task<Employee> GetEmployeeWithAttendanceHistoryById(int id);
    }
}
