using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public DateTime DateOut { get; set; }

        public DateTime DateIn { get; set; }

        public string? Status { get; set; }
        //public virtual Poster? CoursePrice { get; set; } 
    }
}
