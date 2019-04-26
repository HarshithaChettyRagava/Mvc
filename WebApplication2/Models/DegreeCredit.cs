using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class DegreeCredit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1, 999)]
        public int DegreeCreditId { get; set; }
        [Range(1, 999)]
        public int DegreeId { get; set; }
        [Range(1, 999)]
        public int CreditId { get; set; }

        public Degree Degree { get; set; }
        public Credit Credit { get; set; }

    }
}
