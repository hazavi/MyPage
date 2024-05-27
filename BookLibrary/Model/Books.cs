using BookLibrary.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Model
{
    public class Books
    {
        [Key]
        public int BookID { get; set; }

        [Required(ErrorMessage = "Please add a Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please add description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Pages is required")]
        public int Pages { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Status Status { get; set; }
        public int IsFavorite { get; set; }
        public string BookImgCover { get; set; } 

    }
}
