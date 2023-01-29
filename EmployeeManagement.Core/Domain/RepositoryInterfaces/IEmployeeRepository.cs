using EmployeeManagement.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Domain.RepositoryInterfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> GetEmployeeById(int id);
        Task<Employee> GetEmployeeWithAttendanceHistoryById(int id);
    }
}
