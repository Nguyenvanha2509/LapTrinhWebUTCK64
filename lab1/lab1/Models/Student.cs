using System.Data;

namespace lab1.Models
{
    public class Student
    {
        public int Id { get; set; }     //ma sv
        public string? Name { get; set; }   //ho ten
        public string? Email { get; set; }  //email
        public String? Password { get; set; }   //mat khau
        public Branch? Branch { get; set; } //nganh hoc
        public Gender? Gender { get; set; } // gioi tinh
        public bool IsRegular { get; set; }  //he:true-chinh quy; false- phi chinh quy
        public string? Address { get; set; }    //dia chi
        public DateTime DateOfBorth { get; set; }   //ngay sinh

    }
}
