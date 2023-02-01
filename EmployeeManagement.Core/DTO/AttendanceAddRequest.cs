using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Core.DTO
{
    public class AttendanceAddRequest
    {
        [Required(ErrorMessage = "EmployeeId Required")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Date field required")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Checkin time required")]
        public TimeSpan CheckInTime { get; set; }
        [Required(ErrorMessage = "Checkout time required")]
        public TimeSpan CheckOutTime { get; set; }
    }
}
