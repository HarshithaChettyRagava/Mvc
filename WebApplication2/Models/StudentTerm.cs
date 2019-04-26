using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1,999)]
        public int StudentTermId { get; set; }

        public int DegreePlanId { get; set; }

        [Range(1, Int32.MaxValue)]
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        [Range(1, 999)]
        public int StudentTermNo { get; set; }
        [StringLength(20)]
        public string TermAbbrev { get; set; }
        [StringLength(35)]
        public string TermName { get; set; }

        public Student Student { get; set; }
        public DegreePlan DegreePlan { get; set; }

        public ICollection<Slot> Slots { get; set; }
    }
}
