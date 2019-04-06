using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Credit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1, 999)]
        public int CreditId { get; set; }
        [StringLength(40)]
        public string CreditAbrrev { get; set; }
        [StringLength(40)]
        public string CreditName { get; set; }
        [Range(1, 10)]
        public int isSummer { get; set; }
        [Range(1, 10)]
        public int isSpring { get; set; }
        [Range(1, 10)]
        public int isFall { get; set; }

        public bool Done { get; set; }

        public ICollection<Credit> Credits { get; set; }
    }
}
