using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutoring.Shared.Domain
{
    public class CreditCard : BaseDomainModel
    {
        public int CreditNumber { get; set; }
        public string? ExpiryDate { get; set; }
        public int CVC {  get; set; }
        public string? AccountName { get; set; }
        public string? AccountType { get; set;}

    }
}
