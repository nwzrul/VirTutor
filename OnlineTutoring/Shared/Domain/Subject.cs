using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class Subject : BaseDomainModel
    {
        public string? SubjectType { get; set; }
        public string? SubjectLevel { get; set; }
        //public int PosterId { get; set; }
        //public virtual Poster? Poster { get; set; }
    }
}
