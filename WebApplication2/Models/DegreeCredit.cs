using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class DegreeCredit
    {
        public int DegreeCreditID { get; set; }

        public ICollection<Degree> DegreeID { get; set; }
        public ICollection<Credit> CreditID { get; set; }

    }
}
