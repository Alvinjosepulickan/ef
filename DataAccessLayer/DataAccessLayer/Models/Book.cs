using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Book
    {
        [Key]
        public int Book_Id { get; set; }
        [Required]

        [MaxLength(10)]
        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public double Price { get; set; }
        [NotMapped]
        public bool IsDeleted { get; set; }
        /*
        [Required]
        public Author Authors { get; set; }
        [ForeignKey("Author")]
        public int Author_id { get; set; }
        */


        // one to one
        [ForeignKey("BookDetails")]
        public int BookDetails_Id { get; set; }
        public BookDetails BookDetails { get; set; }




        //one to many
        [ForeignKey("Publisher")]
        public int Publisher_Id { get; set; }
        public Publisher Publisher { get; set; }





        //many to many

        public ICollection<BookAuthor> BookAuthors { get; set; }




        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Updated { get; set; }
    }
}
