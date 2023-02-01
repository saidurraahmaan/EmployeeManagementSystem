using EmployeeManagement.Core.Domain.Entities;
using EmployeeManagement.Core.Domain.RepositoryInterfaces;
using EmployeeManagement.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public class AttendanceHisotyRepository : IAttendanceHistoryRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public AttendanceHisotyRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public async Task<AttendanceHistory> AddAttendance(AttendanceHistory attendanceHistory)
        {
            await _employeeDbContext.AttendanceHistories.AddAsync(attendanceHistory);
            await _employeeDbContext.SaveChangesAsync();
            return attendanceHistory;
        }

        public async Task<List<AttendanceHistory>> GetAttendanceHistoryByEmployeeId(int id)
        {
            return await _employeeDbContext.AttendanceHistories
                .Where(x => x.EmployeeId == id)
                .ToListAsync();

        }
    }
}
