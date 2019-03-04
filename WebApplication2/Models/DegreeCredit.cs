using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class DegreeCredit
    {
        public int DegreeCreditID { get; set; }
        public int DegreeID { get; set; }
        public int CreditID { get; set; }


        public ICollection<Credit> Credits { get; set; }

    }
}
