using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class DegreeCredit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeCreditId { get; set; }
        public int DegreeId { get; set; }
        public int CreditId { get; set; }
        //public ICollection<Credit> Credits { get; set; }

    }
}
