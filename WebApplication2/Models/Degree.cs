using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(20, 600000)]
        public int DegreeId { get; set; }
        [StringLength(int.MaxValue, MinimumLength = 35)]
        public string DegreeAbrrev { get; set; }
        public string DegreeName { get; set; }

        //public ICollection<Degree> Degrees { get; set; }
    }
}
