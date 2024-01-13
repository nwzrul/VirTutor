using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class Appointment : BaseDomainModel
    {
        public string? Mode { get; set; }

        public DateTime DateOut { get; set; }

        public DateTime DateIn { get; set; }

        //public int PosterId { get; set; }
        //public virtual Poster? Poster { get; set; }
        //public int StudentId { get; set; }
        //public virtual Student? Student { get; set; }
    }
}
