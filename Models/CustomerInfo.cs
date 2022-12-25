using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class CustomerInfo
    {
        [Display(Name = "Tên Khách")]
        public string CustomerName { get; set; }
        [Display(Name = "Địa Chỉ Email")]

        public string Email { get; set; }
        [DisplayName("Năm Sinh")]
        public int? YearOfBirth { get; set; }
    }
}
