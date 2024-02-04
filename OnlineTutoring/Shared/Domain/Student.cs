using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnlineTutoring.Shared.Domain
{
    public class Student : BaseDomainModel
    {
        [Required(ErrorMessage = "Name is required in this field.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
        public string? StudentName { get; set; }
        public string? StudentImg { get; set; }
        public string? StudentGender { get; set; }
        [Required(ErrorMessage = "Student's age is required.")]
        [Range(8, 18, ErrorMessage = "Student's age must be between 8 and 18.")]
        public int StudentAge { get; set; }
       
        [Required(ErrorMessage = "Contact number is required.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[689]\d{7}$", ErrorMessage = "Contact number entered is not a valid contact number.")]
        public int StudentContact { get; set; }
        [Required(ErrorMessage = "Contact number is required.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[689]\d{7}$", ErrorMessage = "Contact number entered is not a valid contact number.")]
        public int ParentsContact { get; set;}
        //public int? MessageID { get; set; }
        //public virtual Message? Message { get; set; }

    }
}
