using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace OnlineTutoring.Shared.Domain
{
    public class Poster : BaseDomainModel
    {

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Course price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Course price must be greater than 0.")]
        public double CoursePrice { get; set; }



        public int SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }
        //public int TutorId { get; set; }


        public string? Image { get; set; }

        public virtual List<Appointment>? Apppointments { get; set; }
        public virtual List<Review>? Reviews { get; set; }

        public int? TutorId { get; set; }

        public virtual Tutor? Tutor { get; set; }










        //public int MessageId { get; set; }
        //public virtual Message? Message { get; set; }
    }
}
