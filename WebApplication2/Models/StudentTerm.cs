using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class StudentTerm
    {
        public int StudentTermId { get; set; }
        public int StudentTermNo { get; set; }
        public string TermAbbrev { get; set; }
        public string TermName { get; set; }
        public int StudentId { get; set; }
        //public ICollection<Student> Students { get; set; }
    }
}
