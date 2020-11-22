using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentAccounting.Infrastructure.Entities;

namespace StudentAccounting.Infrastructure.EntityConfigurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(s => s.Surname)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(s => s.Middlename)
                .HasMaxLength(60);

            builder.Property(s => s.Gender)
                .IsRequired();

            builder.HasIndex(s => s.UniqueStudentId)
                .IsUnique();

            builder.Property(s => s.UniqueStudentId)
                .HasMaxLength(16);
        }
    }
}
