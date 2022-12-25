using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{

    public class Article
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        [Required]
        [Column(TypeName = "nvarchar")]
        [DisplayName("Tiêu Đề")]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Created { get; set; }
        [Column(TypeName = "ntext")]
        public string Content { get; set; }
    }
}
