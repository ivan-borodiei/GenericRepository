using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Author { get; set; }
    }

    public class BookDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }
    }
}
