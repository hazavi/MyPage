using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Journal.Model
{
    public class Journals
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }


    }
}
