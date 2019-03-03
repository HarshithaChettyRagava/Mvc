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
                    new Credit{CreditID = 644, CreditAbrrev="IOS", CreditName = "IOS", isSummer = 0, isSpring=1, isFall=1}


                };
                Console.WriteLine($"Inserted {credits.Length} new credits.");

                foreach (Credit c in credits)
                {
                    context.Credits.Add(c);
                }

                context.SaveChanges();
            }

            //DegreeCredit table
            if (context.DegreeCredits.Any())
            {
                Console.WriteLine("DegreeCredit already exists");
            }
            else
            {
                var degreeCredits = new DegreeCredit[]
                {
                    new DegreeCredit{DegreeCreditID = 1, DegreeID=3, CreditID = 460},
                    new DegreeCredit{DegreeCreditID = 2, DegreeID=3,   CreditID  = 356},
                    new DegreeCredit{DegreeCreditID = 3,  DegreeID=3,  CreditID  = 542},
                    new DegreeCredit{DegreeCreditID = 4,  DegreeID=3,  CreditID  = 563},
                    new DegreeCredit{DegreeCreditID = 5,  DegreeID=3,  CreditID  = 560},
                    new DegreeCredit{DegreeCreditID = 6, DegreeID=3,  CreditID = 664 },
                    new DegreeCredit{DegreeCreditID = 7, DegreeID=3, CreditID = 618},
                    new DegreeCredit{DegreeCreditID = 8, DegreeID=3,   CreditID  = 555},
                    new DegreeCredit{DegreeCreditID = 9,  DegreeID=3,  CreditID  = 691},
                    new DegreeCredit{DegreeCreditID = 10,  DegreeID=3,  CreditID  = 692},
                    new DegreeCredit{DegreeCreditID = 11,  DegreeID=3,  CreditID  = 643},
                    new DegreeCredit{DegreeCreditID = 12, DegreeID=3,  CreditID = 10 },
                    new DegreeCredit{DegreeCreditID = 13, DegreeID=3, CreditID = 20},
                    new DegreeCredit{DegreeCreditID = 14, DegreeID=3,   CreditID  = 460},
                    new DegreeCredit{DegreeCreditID = 15,  DegreeID=3,  CreditID  = 542},
                    new DegreeCredit{DegreeCreditID = 16,  DegreeID=3,  CreditID  = 563},
                    new DegreeCredit{DegreeCreditID = 17,  DegreeID=3,  CreditID  = 560},
                    new DegreeCredit{DegreeCreditID = 18, DegreeID=3,  CreditID = 664 },
                    new DegreeCredit{DegreeCreditID = 19, DegreeID=3, CreditID = 618},
                    new DegreeCredit{DegreeCreditID = 20, DegreeID=3,   CreditID  = 555},
                    new DegreeCredit{DegreeCreditID = 21,  DegreeID=3,  CreditID  = 691},
                    new DegreeCredit{DegreeCreditID = 22,  DegreeID=3,  CreditID  = 692},
                    new DegreeCredit{DegreeCreditID = 23,  DegreeID=3,  CreditID  = 643},
                    new DegreeCredit{DegreeCreditID = 24, DegreeID=3, CreditID = 10},
                    new DegreeCredit{DegreeCreditID = 25, DegreeID=3,   CreditID  = 20},
                    new DegreeCredit{DegreeCreditID = 26,  DegreeID=3,  CreditID  = 356},
                    new DegreeCredit{DegreeCreditID = 27,  DegreeID=3,  CreditID  = 542},
                    new DegreeCredit{DegreeCreditID = 28,  DegreeID=3,  CreditID  = 563},
                    new DegreeCredit{DegreeCreditID = 29, DegreeID=3,  CreditID = 560 },
                    new DegreeCredit{DegreeCreditID = 30, DegreeID=3, CreditID = 664},
                    new DegreeCredit{DegreeCreditID = 31, DegreeID=3,   CreditID  = 618},
                    new DegreeCredit{DegreeCreditID = 32,  DegreeID=3,  CreditID  = 555},
                    new DegreeCredit{DegreeCreditID = 33,  DegreeID=3,  CreditID  = 691},
                    new DegreeCredit{DegreeCreditID = 34,  DegreeID=3,  CreditID  = 692},
                    new DegreeCredit{DegreeCreditID = 35, DegreeID=3,  CreditID = 643 },
                    new DegreeCredit{DegreeCreditID = 36, DegreeID=3, CreditID = 10},
                    new DegreeCredit{DegreeCreditID = 37, DegreeID=3,   CreditID  = 20},
                    new DegreeCredit{DegreeCreditID = 38,  DegreeID=3,  CreditID  = 542},
                    new DegreeCredit{DegreeCreditID = 39,  DegreeID=3,  CreditID  = 563},
                    new DegreeCredit{DegreeCreditID = 40,  DegreeID=3,  CreditID  = 560},
                    new DegreeCredit{DegreeCreditID = 41, DegreeID=3,  CreditID = 664},
                    new DegreeCredit{DegreeCreditID = 42,  DegreeID=3,  CreditID  = 618},
                    new DegreeCredit{DegreeCreditID = 43, DegreeID=3,  CreditID = 555 },
                    new DegreeCredit{DegreeCreditID = 44,  DegreeID=3,  CreditID  = 691},
                    new DegreeCredit{DegreeCreditID = 45, DegreeID=3,  CreditID = 692},
                    new DegreeCredit{DegreeCreditID = 46,  DegreeID=3,  CreditID  = 644},
                    new DegreeCredit{DegreeCreditID = 47, DegreeID=3,  CreditID = 10 },
                    new DegreeCredit{DegreeCreditID = 48,  DegreeID=3,  CreditID  = 20}
                };
                Console.WriteLine($"Inserted {degreeCredits.Length} new degreecredit.");

                foreach (DegreeCredit d in degreeCredits)
                {
                    context.DegreeCredits.Add(d);
                }

                context.SaveChanges();
            }

            //Degreeplan table
            if (context.Degreeplans.Any())
            {
                Console.WriteLine("DegreePlan already exists");
            }
            else
            {
                var degreeplans = new DegreePlan[]
                {
                    new DegreePlan{DegreePlanID = 7251, StudentID=533569, DegreePlanAbbrev = "Super Fast", DegreePlanName="As fast as I can",DegreeID=3},
                    new DegreePlan{DegreePlanID = 7252, DegreeAbrrev=533569, DegreePlanAbbrev = "Slow and Easy", DegreePlanName="Take a summer off",DegreeID=3},
                    new DegreePlan{DegreePlanID = 7253, DegreeAbrrev=533682, DegreePlanAbbrev = "Easy study plan", DegreePlanName="Study with break",DegreeID=3},
                    new DegreePlan{DegreePlanID = 7254, DegreeAbrrev=533982, DegreePlanAbbrev = "one year plan", DegreePlanName="Complete in one year",DegreeID=3},
                    new DegreePlan{DegreePlanID = 7255, DegreeAbrrev=533573, DegreePlanAbbrev = "slow and steady", DegreePlanName="Maximum semester possible",DegreeID=3},
                    new DegreePlan{DegreePlanID = 7256, DegreeAbrrev=533573, DegreePlanAbbrev = "Default fall plan", DegreePlanName="Default one and half year plan",DegreeID=3},

                };
                Console.WriteLine($"Inserted {degreeplans.Length} new degreeplans.");

                foreach (DegreePlan dp in degreeplans)
                {
                    context.Degreeplans.Add(dp);
                }

                context.SaveChanges();
            }

        }
    }
}