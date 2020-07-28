using Microsoft.EntityFrameworkCore;

namespace CoreWebApp_Lab1.Models
{
    public class CoreWebApp_Lab1Context : DbContext
    {
        public CoreWebApp_Lab1Context (DbContextOptions<CoreWebApp_Lab1Context> options)
            : base(options)
        {
        }

        public DbSet<CoreWebApp_Lab1.Models.Movie> Movie { get; set; }
    }
}
