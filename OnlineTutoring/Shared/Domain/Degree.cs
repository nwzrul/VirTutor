using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class Degree : BaseDomainModel
    {
        public string? DegreeName { get; set; }
        //public string? DegreeLevel { get; set; }
        //public int DegreeYear { get; set; }
        public string? DegreeSchool { get; set; }
    }
}
