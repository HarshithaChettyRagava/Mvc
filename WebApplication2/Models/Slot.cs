using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Slot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotId { get; set; }
        public int DegreePlanId { get; set; }
        public int Term { get; set; }
        public int CreditId { get; set; }
        public string Status { get; set; }

        public DegreePlan DegreePlan { get; set; }
        public Credit Credit { get; set; }
    }
}
