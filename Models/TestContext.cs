using Microsoft.EntityFrameworkCore;

namespace webMusikAPI.Models
{
    public sealed class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        { }
        public DbSet<Comment> Comment { get; set; }
    }

}
