using System.Reflection;
using Microsoft.EntityFrameworkCore;
using StudentAccounting.Infrastructure.Entities;

namespace StudentAccounting.Infrastructure
{
    public class StudentAccountingDbContext : DbContext
    {
        public StudentAccountingDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
