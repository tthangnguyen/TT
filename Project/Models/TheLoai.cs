using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class TheLoai
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "ko được phép để trống")]
        [StringLength(10, ErrorMessage = "{0} độ dài phải từ {2} đến {1} ký tự ", MinimumLength = 8)]
        [Display(Name = "Thể Loại")]

        public string Name { get; set; }
        [Required(ErrorMessage = "ko được phép để trống")]
        [Display(Name = "Ngày tạo")]

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
