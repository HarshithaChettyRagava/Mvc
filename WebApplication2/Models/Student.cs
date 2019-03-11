using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public int Snumber { get; set; }
        public int Num919 { get; set; }
    }
}