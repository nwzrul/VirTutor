using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace OnlineTutoring.Shared.Domain
{
    public class Appointment : BaseDomainModel
    {

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Title must be between 2 and 100 characters.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Mode is required.")]
        public string? Mode { get; set; }
        [Required(ErrorMessage = "Time is required.")]
        public string? Time { get; set; }
        
        public string? Duration { get; set; }

        public DateTime DateOut { get; set; }

        public DateTime DateIn { get; set; }


        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string? Description { get; set; }


        public int? StudentId { get; set; }
        public virtual Student? Student { get; set; }

        public int? TutorId { get; set; }
        public virtual Tutor? Tutor { get; set; }
        public int? PosterId { get; set; }
        public virtual Poster? Poster { get; set; }
        //public virtual Poster? Poster { get; set; }
        //public int StudentId { get; set; }

    }
}
