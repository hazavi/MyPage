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
        public string Title { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public Author Author { get; set; } = new Author();
        public DateTime ReleaseDate { get; set; }
        public Status Status { get; set; }
        public int IsFavorite { get; set; }
        public string PhotoCover { get; set; }

    }
}
