using AdminBooks.Data.Models.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace AdminBooks.Data
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options):base(options)
        {
            
        }
     
    }
}
