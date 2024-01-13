using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class Tutor : BaseDomainModel
    {
        public string? TutorName { get; set; }
        public string? TutorGender { get; set; }
        public int TutorAge { get; set; }
        //public int QualificationId { get; set; }
        //public virtual Qualification? Qualification { get; set; }
        public virtual List<Appointment>? Appointments { get; set; }
    }
}
