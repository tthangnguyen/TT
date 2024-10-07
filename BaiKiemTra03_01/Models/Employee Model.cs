namespace BaiKiemTra03_01.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }  // Mã nhân viên
        public string EmployeeName { get; set; }  // Tên nhân viên
        public string Position { get; set; }  // Chức vụ
        public int DepartmentId { get; set; }  // Mã phòng ban (Khóa ngoại)
        public Department Department { get; set; }  // Khóa ngoại liên kết tới bảng Phòng ban
        public DateTime HireDate { get; set; }  // Ngày bắt đầu làm việc
    }
}
