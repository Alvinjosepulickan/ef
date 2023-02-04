using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        //public Book Books { get; set; }
        //[ForeignKey("Book")]
        //public int Book_id { get; set; }


        //many to many

        public ICollection<BookAuthor> BookAuthors;
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Location { get; set; }
    }
}
