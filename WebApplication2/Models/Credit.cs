using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Credit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreditId { get; set; }
        public string CreditAbrrev { get; set; }
        public string CreditName { get; set; }
        public int isSummer { get; set; }
        public int isSpring { get; set; }
        public int isFall { get; set; }
    }
}
