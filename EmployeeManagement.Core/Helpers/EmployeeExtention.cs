using EmployeeManagement.Core.Domain.Entities;
using EmployeeManagement.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Helpers
{
    public static class EmployeeExtention
    {
        public static EmployeeResponseDetails ToEmployeeResponseDetail(this Employee employee)
        {
            return new EmployeeResponseDetails()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                FullName = employee.FirstName + " " + employee.LastName,
                Email = employee.Email,
                Phone = employee.Phone,
                Address = employee.Address,
                TIN = employee.TIN,
                HireDate = employee.HireDate,
                Age = (DateTime.Today.Year - Convert.ToDateTime(employee.DateOfBirth).Year),
                AttendanceHistories = employee.AttendanceHistories,
            };
        }
    }
}
