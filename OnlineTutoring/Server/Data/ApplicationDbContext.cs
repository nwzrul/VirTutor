using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OnlineTutoring.Server.Configurations.Entities;
using OnlineTutoring.Server.Models;
using OnlineTutoring.Shared.Domain;

namespace OnlineTutoring.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Poster> Posters { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Diploma> Diplomas { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<CreditCard> Credits { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new TutorSeedConfiguration());

            builder.ApplyConfiguration(new StudentSeedConfiguration());

            builder.ApplyConfiguration(new SubjectSeedConfiguration());

            builder.ApplyConfiguration(new RoleSeedConfiguration());

            builder.ApplyConfiguration(new UserSeedConfiguration());

            builder.ApplyConfiguration(new UserRoleSeedConfiguration());

            builder.ApplyConfiguration(new PosterSeedConfiguration());
        }

    }
}
