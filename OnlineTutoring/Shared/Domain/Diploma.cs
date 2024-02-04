using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class Diploma : BaseDomainModel
    {
        public string? DiplomaName { get; set; }
        //public string? DiplomaLevel { get; set; }
        public int DiplomaYear { get; set; }
        public string? DiplomaSchool { get; set; }

    }
}
