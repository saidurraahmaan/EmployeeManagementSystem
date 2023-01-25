﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Domain.Entities
{
    public class Employee
    {
        public int RecId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;   
        public DateOnly? DateOfBirth { get; set; }
        public DateOnly HireDate { get; set; }
        public string? Address { get; set; } = string.Empty;
        public string TIN { get; set; } = string.Empty;

        [ForeignKey("EmployeeAttendance_Id")]
        public virtual List<AttendanceHistory>  attendanceHistories { get; set; } = new List<AttendanceHistory>();
    }
}