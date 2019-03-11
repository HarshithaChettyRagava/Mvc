﻿using System;
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
        public int Term { get; set; }
        public string Status { get; set; }
        public int DegreePlanId { get; set; }
        public int CreditId { get; set; }
        //public ICollection<DegreePlan> DegreePlans { get; set; }
        //public ICollection<Credit> Credits { get; set; }
    }
}
