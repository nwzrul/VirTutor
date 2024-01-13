using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class Message : BaseDomainModel
    {
        public string? Status { get; set; }
        public string? MessageContent { get; set; }
        //public int StudentId { get; set; }
        //public virtual Student? Student { get; set; }
        //public int TutorId { get; set; }
        //public virtual Tutor? Tutor { get; set; }
    }
}
