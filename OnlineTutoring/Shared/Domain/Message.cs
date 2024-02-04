using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class Message : BaseDomainModel
    {
        public string? SenderName { get; set; }
        public string? MessageContent { get; set; }
        public DateTime Timestamp { get; set; }
        public int? TutorID { get; set; }
        public virtual Tutor? Tutor { get; set; }
        public int? StudentID { get; set; }
        public virtual Student? Student { get; set; }
        public int? MessageId { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
    }
}
