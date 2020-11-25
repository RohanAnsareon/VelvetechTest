using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentAccounting.Infrastructure.Entities;

namespace StudentAccounting.Infrastructure.EntityConfigurations
{
    public class StudentGroupConfiguration : IEntityTypeConfiguration<StudentGroup>
    {
        public void Configure(EntityTypeBuilder<StudentGroup> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.GroupId });

            builder.HasOne(sc => sc.Student)
                .WithMany(s => s.StudentGroups)
                .HasForeignKey(sc => sc.StudentId);

            builder.HasOne(sc => sc.Group)
                .WithMany(g => g.StudentGroups)
                .HasForeignKey(sc => sc.GroupId);
        }
    }
}
