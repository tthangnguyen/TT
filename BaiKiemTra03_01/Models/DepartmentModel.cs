namespace BaiKiemTra03_01.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }  // Mã phòng ban
        public string DepartmentName { get; set; }  // Tên phòng ban
        public int NumberOfEmployees { get; set; }  // Số lượng nhân viên
        public int ManagerDepartmentId { get; set; }  // Mã quản lý phòng ban

        // Liên kết với nhân viên
        public ICollection<Employee> Employees { get; set; }  // Danh sách nhân viên trong phòng ban
    }

}
