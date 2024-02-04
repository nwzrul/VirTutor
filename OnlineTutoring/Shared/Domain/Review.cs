using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineTutoring.Shared.Domain
{
    public class Review : BaseDomainModel
    {

        [Required(ErrorMessage = "Review content is required.")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Review content must be between 5 and 500 characters.")]
        public string? ReviewContent { get; set; }
        [Range(1, 5, ErrorMessage = "Stars must be between 1 and 5.")]
        public int Stars { get; set; }
       


    }
}
