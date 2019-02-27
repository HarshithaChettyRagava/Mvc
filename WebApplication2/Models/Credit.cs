using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Credit
    {
        public int CreditID { get; set; }
        public string CreditAbrrev { get; set; }
        public string CreditName { get; set; }
        public string isSummer { get; set; }
        public string isSpring { get; set; }
        public string isFall { get; set; }
    }
}
