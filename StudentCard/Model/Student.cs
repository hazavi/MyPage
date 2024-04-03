using StudentCard.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCard.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public int StudentID { get; set; }
        [Required(ErrorMessage = "School Name is required")]
        public string School { get; set; }
        [Required(ErrorMessage = "Specify your Education")]
        public string Education { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "BirthDate is required")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Select Gender")]
        public Gender Gender { get; set; }
        public List<string> Hobbies { get; set; } 
        public string Sport { get; set; }
        public string PicURL { get; set; }

        public Student()
        {
            // Generate a 5-digit random student ID
            Random random = new Random();
            this.StudentID = random.Next(10000, 999999999);

            Hobbies = new List<string>();
        }
   
    }
}
