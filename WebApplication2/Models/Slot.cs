using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Slot
    {
        public int SlotID { get; set; }
        public string Term { get; set; }
        public string Status { get; set; }

        public ICollection<DegreePlan> DegreenPlanID { get; set; }
        public ICollection<Credit> CreditID { get; set; }
    }
}
