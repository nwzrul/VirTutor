using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineTutoring.Shared.Domain;
using System.Drawing;

namespace OnlineTutoring.Server.Configurations.Entities
{
    public class DegreeSeedConfiguration : IEntityTypeConfiguration<Degree>
    {
        public void Configure(EntityTypeBuilder<Degree> builder)
        {
            builder.HasData(
            new Degree
            {
                Id = 1,
                DegreeName = "Computer Science",
                DegreeSchool = "NUS",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Degree
            {
                Id = 2,
                DegreeName = "Early Childhood",
                DegreeSchool = "UTP",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
            );
        }
    }
}
