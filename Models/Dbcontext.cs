using Microsoft.EntityFrameworkCore;

namespace MoviesAPI.Models
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions<DbContext>options):base(options)  
        { }

    }
}
