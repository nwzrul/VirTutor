using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class Tutor : BaseDomainModel
    {
        [Required(ErrorMessage = "Name is required in this field.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name entered does not meet the length requirement.")]
        public string? TutorName { get; set; }
        public string? TutorGender { get; set; }
        [Required(ErrorMessage = "Tutor's age is required.")]
        [Range(18, 65, ErrorMessage = "Tutor's age must be between 18 and 65.")]
        public int TutorAge { get; set; }
        //[Required(ErrorMessage = "Please show valid credentials such as your LinkedIn profile.")]
        public string? Qualification {  get; set; }
        public string? DegreeName { get; set; }
        public string? DiplomaName { get; set; }
        public string? TutorImg {  get; set; }

        //public int QualificationId { get; set; }
        public int? DiplomaID { get; set; }
        public virtual Diploma? Diploma { get; set; }
        public virtual List<Appointment>? Appointments { get; set; }
        public int? DegreeID { get; set; }
        public virtual Degree? Degree { get; set; }
        //public int? MessageID { get; set; }
        //public virtual Message? Message { get; set; }
    }
}
