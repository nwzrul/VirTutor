using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class Student : BaseDomainModel
    {
        public string? StudentName { get; set; }
        public string? StudentGender { get; set; }
        public int StudentAge { get; set; }
        public int StudentContact { get; set; }
        public int ParentsContact { get; set;}

    }
}
