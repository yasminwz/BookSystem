using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSystem.Models
{
    [Table("Book")]
    public class Book
    {
            [Key]
            public int book_id { get; set; }

            [Column("name_book")]
            [Display(Name = "Book Name")]
            public string bookName { get; set; }
            
            [Column("price")]
            [Display(Name = "Price")]
            public decimal price { get; set; }

            [Column("number_pages")]
            [Display(Name = "Book number pages")]
            public int numberOfPages { get; set; }
            }
    }
       

