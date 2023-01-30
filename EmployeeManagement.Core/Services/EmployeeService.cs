using EmployeeManagement.Core.Domain.RepositoryInterfaces;
using EmployeeManagement.Core.DTO;
using EmployeeManagement.Core.Helpers;
using EmployeeManagement.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeResponseDetails> AddEmployee(EmployeeAddRequest employee)
        {
            var emp = employee.ToEmployee();
            var res = await _employeeRepository.AddEmployee(emp);
            return res.ToEmployeeResponseDetail();
        }

        public Task<AttendanceResponse> GetEmployeeAttendanceById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeResponseDetails> GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
