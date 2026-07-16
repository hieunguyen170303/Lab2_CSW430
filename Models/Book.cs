using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Q1WebAPI.Models
{
    [Table("BOOKS")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bookid { get; set; }

        [StringLength(100)]
        public string? name { get; set; }

        [StringLength(512)]
        public string? description { get; set; }

        public decimal? price { get; set; }

        [StringLength(128)]
        public string? note { get; set; }
    }
}
