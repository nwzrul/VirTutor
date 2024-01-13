using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public string? ReviewContent { get; set; }
        public int Stars {  get; set; }
        //public int PosterId { get; set; }
        //public virtual Poster? Poster { get; set; }
        //public int StudentId { get; set; }
        //public virtual Student? Student { get; set; }
    }
}
