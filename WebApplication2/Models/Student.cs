using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1, Int32.MaxValue)]
        public int StudentId { get; set; }
        [StringLength(35)]
        public string FamilyName { get; set; }
        [StringLength(35)]
        public string GivenName { get; set; }
        [Range(1,Int32.MaxValue)]
        public int Snumber { get; set; }
        [Range(1,Int32.MaxValue)]
        public int Num919 { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}