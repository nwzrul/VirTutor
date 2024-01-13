using OnlineTutoring.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutoring.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Tutor> Tutors { get; }
        IGenericRepository<Subject> Subjects { get; }
        IGenericRepository<Student> Students { get; }
        IGenericRepository<Poster> Posters { get; }
        IGenericRepository<Appointment> Appointments { get; }
        IGenericRepository<CreditCard> Credits { get; }
        IGenericRepository<Diploma> Diplomas { get; }
        IGenericRepository<Degree> Degrees { get; }
        IGenericRepository<Message> Messages { get; }
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<Qualification> Qualifications { get; }
        IGenericRepository<Review> Reviews { get; }
    }
}