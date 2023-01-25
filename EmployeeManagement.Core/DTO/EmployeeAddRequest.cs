using EmployeeManagement.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.DTO
{
    public class EmployeeAddRequest
    {
        [Required(ErrorMessage ="First Name can't be blank")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "First Name can't be blank")]
        public string LastName { get; set; } = string.Empty;
        [Required,EmailAddress(ErrorMessage ="Email is not valid")]
        public string Email { get; set; } = string.Empty;
        [Phone]
        public string Phone { get; set; } = string.Empty;
        public DateOnly? DateOfBirth { get; set; }
        [Required(ErrorMessage ="Hire Date is required")]
        public DateOnly HireDate { get; set; }
        public string TIN { get; set; } = string.Empty;


        public Employee ToEmployee()
        {
            return new Employee() 
            { 
                Phone = Phone, 
                FirstName = FirstName, 
                LastName = LastName, 
                Email = Email, 
                TIN = TIN, 
                DateOfBirth = DateOfBirth,
                HireDate = HireDate,
            };
        }
    }
}
