namespace EmployeeManagement.Core.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public string? Address { get; set; } = string.Empty;
        public string TIN { get; set; } = string.Empty;

        public virtual List<AttendanceHistory> AttendanceHistories { get; set; } = new List<AttendanceHistory>();
    }
}
