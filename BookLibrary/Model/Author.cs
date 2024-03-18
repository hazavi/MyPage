using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Model
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide an Author")]
        [StringLength(100)]
        public string Name { get; set; }
        public string? Description { get; set; }
        
        
    }
}
