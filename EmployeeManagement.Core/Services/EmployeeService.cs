using EmployeeManagement.Core.Domain.RepositoryInterfaces;
using EmployeeManagement.Core.DTO;
using EmployeeManagement.Core.Helpers;
using EmployeeManagement.Core.ServiceInterfaces;

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

        public async Task<AttendanceResponse> GetEmployeeAttendanceById(int employeeId)
        {
            var attendances = await _employeeRepository.GetEmployeeWithAttendanceHistoryById(employeeId);
            //return attendances;
            throw new NotImplementedException();
        }

        public async Task<EmployeeResponseDetails> GetEmployeeById(int employeeId)
        {
            var employee = await _employeeRepository.GetEmployeeById(employeeId);
            return employee.ToEmployeeResponseDetail();
        }
    }
}
