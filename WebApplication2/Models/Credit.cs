using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Credit
    {
        public int CreditId { get; set; }
        public string CreditAbrrev { get; set; }
        public string CreditName { get; set; }
        public int isSummer { get; set; }
        public int isSpring { get; set; }
        public int isFall { get; set; }
    }
}
