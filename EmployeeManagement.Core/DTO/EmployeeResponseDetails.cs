using EmployeeManagement.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.DTO
{
    public class EmployeeResponseDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public int Age { get; set; }
        public DateTime HireDate { get; set; }
        public string? Address { get; set; } = string.Empty;
        public string TIN { get; set; } = string.Empty;
        public  List<AttendanceHistory> attendanceHistories { get; set; } = new List<AttendanceHistory>();
    
        
    }

    public static class EmployeeExtention
    {
        public static EmployeeResponseDetails ToEmployeeResponseDetail(this Employee employee)
        {
            return new EmployeeResponseDetails()
            {
                Id = employee.RecId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                FullName = employee.FirstName + " " + employee.LastName,
                Email = employee.Email,
                Phone = employee.Phone,
                Address = employee.Address,
                TIN = employee.TIN,
                HireDate = employee.HireDate,
                Age = (DateTime.Today.Year  - Convert.ToDateTime(employee.DateOfBirth).Year),
                attendanceHistories = employee.attendanceHistories,
            };
        }
    }
}
