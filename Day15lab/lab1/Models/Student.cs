using System.ComponentModel.DataAnnotations;
using System.Data;

namespace lab1.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Họ tên bắt buộc nhập")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ tên từ 4 đến 100 ký tự")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@gmail\.com$", ErrorMessage = "Email phải có định dạng đúng và đuôi gmail.com")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu bắt buộc nhập")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải từ 8 ký tự")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$", ErrorMessage = "Mật khẩu phải có chữ hoa, chữ thường, số và ký tự đặc biệt")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Ngành học bắt buộc chọn")]
        public Branch? Branch { get; set; }

        [Required(ErrorMessage = "Giới tính bắt buộc chọn")]
        public Gender? Gender { get; set; }

        public bool IsRegular { get; set; }

        [Required(ErrorMessage = "Địa chỉ bắt buộc nhập")]
        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Ngày sinh bắt buộc nhập")]
        [Range(typeof(DateTime), "1963-01-01", "2005-12-31", ErrorMessage = "Ngày sinh phải từ 1963 đến 2005")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Điểm bắt buộc nhập")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải từ 0.0 đến 10.0")]
        public double Score { get; set; }
    }

    
}
