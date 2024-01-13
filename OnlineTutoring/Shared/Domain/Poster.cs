using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class Poster : BaseDomainModel
    {
        public string? Description { get; set; }
        public double CoursePrice { get; set; }
        //public int SubjectId { get; set; }
        //public virtual Subject? Subject { get; set; }
        //public int TutorId { get; set; }
        //public virtual Tutor? Tutor { get; set; }
        //public int AppointmentId { get; set; }
        //public virtual Appointment? Appointment { get; set; }
        //public int MessageId { get; set; }
        //public virtual Message? Message { get; set; }
    }
}
