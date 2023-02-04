using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("tb_Category")]
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        [Column("CategoryName")]
        public string Name { get; set; }
    }
}
