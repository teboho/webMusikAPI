using Microsoft.EntityFrameworkCore;

namespace webMusikAPI.Models
{
    public sealed class WebMusikContext : DbContext
    {
        public WebMusikContext(DbContextOptions<WebMusikContext> options)
            : base(options)
        { }
        public DbSet<Comment> Comment { get; set; }
    }

}
