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
        [Range(1, 999)]
        public int DegreeId { get; set; }
        [StringLength(40)]
        public string DegreeAbrrev { get; set; }
        [StringLength(40)]
        public string DegreeName { get; set; }

        public bool Done { get; set; }

        public ICollection<Degree> Degrees { get; set; }
    }
}
