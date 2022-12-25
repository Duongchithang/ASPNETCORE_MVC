using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Phải Nhập {0}")]
        [Display(Name = "Họ Và Tên")]
        public string FullName { set; get; }
        [Required]
        [StringLength(100)]
        public string Email { set; get; }
        public DateTime DataSent { set; get; }
        public string Message { set; get; }
        [StringLength(50)]
        public string Phone { set; get; }
        public Contact()
        {

        }

    }

}