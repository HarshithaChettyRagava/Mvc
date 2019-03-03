using System;
using System.Linq;
using DegreePlanner.Models;
using DegreePlanner.Data;

namespace DegreePlanner.Data
{
    public static class DbIntializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degree already exists");
            }
            else
            {
                var degrees = new Degree[]
                {
                    new Degree{DegreeID = 1, DegreeAbbr="ACS+2", DegreeName = "MS ACS+2"},
                };
                Console.WriteLine();

                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }

                context.Savechanges();
            }

        }
    }
}