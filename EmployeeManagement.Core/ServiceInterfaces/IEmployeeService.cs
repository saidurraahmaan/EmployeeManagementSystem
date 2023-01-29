﻿using EmployeeManagement.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.ServiceInterfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeAddRequest> AddEmployee(EmployeeAddRequest employee);
        Task<AttendanceAddRequest> AddEmployeeAttendance(AttendanceAddRequest employee);
        Task<EmployeeResponseDetails> GetEmployeeById(int employeeId);
        Task<AttendanceResponse> GetEmployeeAttendanceById(int employeeId);

    }
}
