using Microsoft.EntityFrameworkCore;

namespace Student.Data
{
    public class ApplicationDbContext: DbContext

    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student.Models.Entities.Student> Students { get; set; }

    }
}
