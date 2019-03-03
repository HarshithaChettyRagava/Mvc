using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication2.Models;
using WebApplication2.Data;

namespace WebApplication2.Data
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
                    new Degree{DegreeID = 1, DegreeAbrrev="ACS+2", DegreeName = "MS ACS+2"},
                    new Degree{DegreeID = 2, DegreeAbrrev="ACS+DB", DegreeName = "MS ACS+DB"},
                    new Degree{DegreeID = 3, DegreeAbrrev="ACS+NF", DegreeName = "MS ACS+NF"},
                    new Degree{DegreeID = 4, DegreeAbrrev="ACS", DegreeName = "MS ACS"},

                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");

                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }

                context.SaveChanges();
            }


            //Credit table
            if (context.Credits.Any())
            {
                Console.WriteLine("Credit already exists");
            }
            else
            {
                var credits = new Credit[]
                {
                    new Credit{CreditID = 460, CreditAbrrev="DB", CreditName = "Databases", isSummer = 0, isSpring=1, isFall=1},
                    new Credit{CreditID = 356, CreditAbrrev="NF", CreditName = "Network Fundamentals", isSummer = 0, isSpring=1, isFall=1},
                    new Credit{CreditID = 542, CreditAbrrev="542-OOP", CreditName = "OOP with Java", isSummer = 0, isSpring=1, isFall=1},
                    new Credit{CreditID = 563, CreditAbrrev="563-Web", CreditName = "Web Apps", isSummer = 0, isSpring=1, isFall=1},
                    new Credit{CreditID = 560, CreditAbrrev="560-ADB", CreditName = "Advanced Databases", isSummer = 1, isSpring=1, isFall=1},
                    new Credit{CreditID = 664, CreditAbrrev="664-UX", CreditName = "User Experience", isSummer = 0, isSpring=1, isFall=1},
                    new Credit{CreditID = 618, CreditAbrrev="618-PM", CreditName = "Project Management", isSummer = 1, isSpring=0, isFall=0},
                    new Credit{CreditID = 555, CreditAbrrev="555-NS", CreditName = "Network Security", isSummer = 0, isSpring=1, isFall=1},
                    new Credit{CreditID = 691, CreditAbrrev="691-GDP1", CreditName = "GDP1", isSummer = 1, isSpring=1, isFall=1},
                    new Credit{CreditID = 692, CreditAbrrev="692-GDP2", CreditName = "GDP2", isSummer = 0, isSpring=1, isFall=1},
                    new Credit{CreditID = 643, CreditAbrrev="643-Android", CreditName = "Android", isSummer = 0, isSpring=1, isFall=1},
                    new Credit{CreditID = 10, CreditAbrrev="E1", CreditName = "Elective1", isSummer = 0, isSpring=1, isFall=1},
                    new Credit{CreditID = 20, CreditAbrrev="E2", CreditName = "Elective2", isSummer = 0, isSpring=1, isFall=1},
                    new Credit{CreditID = 644, CreditAbrrev="IOS", CreditName = "IOS", isSummer = 0, isSpring=1, isFall=1},


                };
                Console.WriteLine($"Inserted {credits.Length} new credits.");

                foreach (Credit c in credits)
                {
                    context.Credits.Add(c);
                }

                context.SaveChanges();
            }

        }
    }
}