using System.ComponentModel.DataAnnotations;

namespace MyPage.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide a UserName")]
        [StringLength(100)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please provide a Password")]
        [StringLength(100)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Confirm Password")]
        [StringLength(100)]
        public string Password2 { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
