using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermId { get; set; }
        public int StudentId { get; set; }
        public int StudentTermNo { get; set; }
        public string TermAbbrev { get; set; }
        public string TermName { get; set; }

        public Student Student { get; set; }
    }
}
