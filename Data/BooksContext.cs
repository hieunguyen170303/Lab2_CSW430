using Microsoft.EntityFrameworkCore;
using Q1WebAPI.Models;

namespace Q1WebAPI.Data
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
    }
}
