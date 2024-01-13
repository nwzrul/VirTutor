using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineTutoring.Shared.Domain;
using System.Drawing;

namespace OnlineTutoring.Server.Configurations.Entities
{
    public class StudentSeedConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
            new Student
            {
                Id = 1,
                StudentName = "John",
                StudentAge = 11,
                StudentGender = "Male",
                StudentContact = 123,
                ParentsContact = 456,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Student
            {
                Id = 2,
                StudentName = "Aliyah",
                StudentAge = 18,
                StudentGender = "Female",
                StudentContact = 123,
                ParentsContact = 456,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
            );
        }
    }
}
