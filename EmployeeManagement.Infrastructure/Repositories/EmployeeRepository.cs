using EmployeeManagement.Core.Domain.Entities;
using EmployeeManagement.Core.Domain.RepositoryInterfaces;
using EmployeeManagement.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            await _employeeDbContext.Employees.AddAsync(employee);
            await _employeeDbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _employeeDbContext.Employees
                .FirstOrDefaultAsync(x => x.Id == id) ?? new Employee();
        }

        public async Task<Employee> GetEmployeeWithAttendanceHistoryById(int id)
        {
            return await _employeeDbContext.Employees
                .Include(a => a.AttendanceHistories)
                .FirstOrDefaultAsync(x => x.Id == id) ?? new Employee();
        }
    }
}
