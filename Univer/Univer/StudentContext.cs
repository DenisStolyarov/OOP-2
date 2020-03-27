using Microsoft.EntityFrameworkCore;

namespace Univer
{
    public class StudentContext : DbContext
    {
        private readonly string connection = @"Data Source=DESKTOP-U51EB46\SQLEXPRESS;Initial Catalog=Univer_Students;Integrated Security=True";

        public DbSet<Student> Student { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public StudentContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }
    }
}
