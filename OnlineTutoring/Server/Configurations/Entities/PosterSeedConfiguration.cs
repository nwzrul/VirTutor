using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineTutoring.Shared.Domain;
using System.Drawing;

namespace OnlineTutoring.Server.Configurations.Entities
{
    public class PosterSeedConfiguration : IEntityTypeConfiguration<Poster>
    {
        public void Configure(EntityTypeBuilder<Poster> builder)
        {
            builder.HasData(
            new Poster
            {
                Id = 1,
                Description = "Math for Meth-Heads",
                CoursePrice = 150.99,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Poster
            {
                Id = 2,
                Description = "Science",
                CoursePrice = 299.99,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
            );
        }
    }
}
