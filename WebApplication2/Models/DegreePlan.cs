using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class DegreePlan
    {
        public int DegreePlanID { get; set; }
        public string DegreePlanAbbrev { get; set; }
        public string DegreePlanName { get; set; }
        public int StudentID { get; set; }
        public int DegreeID { get; set; }
        public Student Student { get; set; }
        public Degree Degree { get; set; }
    }
}
