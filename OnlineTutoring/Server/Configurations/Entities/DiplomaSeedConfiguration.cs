using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineTutoring.Shared.Domain;
using System.Drawing;

namespace OnlineTutoring.Server.Configurations.Entities
{
    public class DiplomaSeedConfiguration : IEntityTypeConfiguration<Diploma>
    {
        public void Configure(EntityTypeBuilder<Diploma> builder)
        {
            builder.HasData(
            new Diploma
            {
                Id = 1,
                DiplomaName = "Computer Science",
                DiplomaSchool = "Temasek Polytechnic",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Diploma
            {
                Id = 2,
                DiplomaName = "Early Childhood",
                DiplomaSchool = "Republic Polytechnic",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
            );
        }
    }
}
