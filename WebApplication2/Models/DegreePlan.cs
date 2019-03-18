using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class DegreePlan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1, 9999)]
        public int DegreePlanId { get; set; }
        [Range(1, Int32.MaxValue)]
        public int StudentId { get; set; }
        [StringLength(50)]
        public string DegreePlanAbbrev { get; set; }
        [StringLength(50)]
        public string DegreePlanName { get; set; }
        [Range(1, 999)]
        public int DegreeId { get; set; }

        public Student Student { get; set; }
        public Degree Degree { get; set; }
        public ICollection<DegreePlan> DegreePlans { get; set; }
    }
}
