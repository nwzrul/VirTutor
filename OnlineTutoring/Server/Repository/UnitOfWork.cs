using OnlineTutoring.Server.Data;
using OnlineTutoring.Server.IRepository;
using OnlineTutoring.Server.Models;
using OnlineTutoring.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineTutoring.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Tutor> _tutors;
        private IGenericRepository<Student> _students;
        private IGenericRepository<Subject> _subjects;
        private IGenericRepository<Appointment> _appointments;
        private IGenericRepository<CreditCard> _credits;
        private IGenericRepository<Degree> _degrees;
        private IGenericRepository<Diploma> _diplomas;
        private IGenericRepository<Message> _messages;
        private IGenericRepository<Payment> _payments;
        private IGenericRepository<Poster> _posters;
        private IGenericRepository<Qualification> _qualifications;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<Gender> _genders;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Tutor> Tutors
            => _tutors ??= new GenericRepository<Tutor>(_context);
        public IGenericRepository<Student> Students
            => _students ??= new GenericRepository<Student>(_context);
        public IGenericRepository<Subject> Subjects
            => _subjects ??= new GenericRepository<Subject>(_context);
        public IGenericRepository<Appointment> Appointments
            => _appointments ??= new GenericRepository<Appointment>(_context);
        public IGenericRepository<CreditCard> Credits
            => _credits ??= new GenericRepository<CreditCard>(_context);
        public IGenericRepository<Degree> Degrees
            => _degrees ??= new GenericRepository<Degree>(_context);
        public IGenericRepository<Diploma> Diplomas
            => _diplomas ??= new GenericRepository<Diploma>(_context);
        public IGenericRepository<Message> Messages
            => _messages ??= new GenericRepository<Message>(_context);
        public IGenericRepository<Payment> Payments
            => _payments ??= new GenericRepository<Payment>(_context);
        public IGenericRepository<Poster> Posters
            => _posters ??= new GenericRepository<Poster>(_context);
        public IGenericRepository<Qualification> Qualifications
            => _qualifications ??= new GenericRepository<Qualification>(_context);
        public IGenericRepository<Review> Reviews
            => _reviews ??= new GenericRepository<Review>(_context);
        public IGenericRepository<Gender> Genders
            => _genders ??= new GenericRepository<Gender>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}