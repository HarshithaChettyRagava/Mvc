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

            //Student table
            if (context.Students.Any())
            {
                Console.WriteLine("Student already exists");
            }
            else
            {
                var students = new Student[]
                {
                    new Student{StudentID = 1, FamilyName="Chetty Ragava", GivenName = "Harshitha", Snumber = 533569, Num919 = 919568034},
                    new Student{StudentID = 2, FamilyName="Ali", GivenName = "Zaiba", Snumber = 533982, Num919 = 919569110},
                    new Student{StudentID = 3, FamilyName="Nuka", GivenName = "Vamshi krishna", Snumber = 533573, Num919 = 919570332},

                };
                Console.WriteLine($"Inserted {students.Length} new students.");

                foreach (Student st in students)
                {
                    context.Students.Add(st);
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
            if (context.DegreePlans.Any())
            {
                Console.WriteLine("DegreePlan already exists");
            }
            else
            {
                var degreeplans = new DegreePlan[]
                {
                    new DegreePlan{DegreePlanID = 7251, StudentID=533569, DegreePlanAbbrev = "Super Fast", DegreePlanName="As fast as I can",DegreeID=3},
                    new DegreePlan{DegreePlanID = 7252, StudentID=533569, DegreePlanAbbrev = "Slow and Easy", DegreePlanName="Take a summer off",DegreeID=3},
                    new DegreePlan{DegreePlanID = 7253, StudentID=533682, DegreePlanAbbrev = "Easy study plan", DegreePlanName="Study with break",DegreeID=3},
                    new DegreePlan{DegreePlanID = 7254, StudentID=533982, DegreePlanAbbrev = "one year plan", DegreePlanName="Complete in one year",DegreeID=3},
                    new DegreePlan{DegreePlanID = 7255, StudentID=533573, DegreePlanAbbrev = "slow and steady", DegreePlanName="Maximum semester possible",DegreeID=3},
                    new DegreePlan{DegreePlanID = 7256, StudentID=533573, DegreePlanAbbrev = "Default fall plan", DegreePlanName="Default one and half year plan",DegreeID=3},

                };
                Console.WriteLine($"Inserted {degreeplans.Length} new degreeplans.");

                foreach (DegreePlan dp in degreeplans)
                {
                    context.Degreeplans.Add(dp);
                }

                context.SaveChanges();
            }

            //Slot table
            if (context.Slots.Any())
            {
                Console.WriteLine("Slot already exists");
            }
            else
            {
                var slots = new Slot[]
                {
                    new Slot{SlotID = 1, DegreePlanID=7251, Term = 1, CreditID=542, Status="C"},
                    new Slot{SlotID = 2, DegreePlanID=7251, Term = 1, CreditID=563, Status="C"},
                    new Slot{SlotID = 3, DegreePlanID=7251, Term = 1, CreditID=560, Status="C"},
                    new Slot{SlotID = 4, DegreePlanID=7251, Term = 2, CreditID=664, Status="A"},
                    new Slot{SlotID = 5, DegreePlanID=7251, Term = 2, CreditID=6, Status="A"},
                    new Slot{SlotID = 6, DegreePlanID=7251, Term = 2, CreditID=10, Status="A"},
                    new Slot{SlotID = 7, DegreePlanID=7251, Term = 3, CreditID=618, Status="P"},
                    new Slot{SlotID = 8, DegreePlanID=7251, Term = 3, CreditID=691, Status="P"},
                    new Slot{SlotID = 9, DegreePlanID=7251, Term = 4, CreditID=692, Status="P"},
                    new Slot{SlotID = 10, DegreePlanID=7251, Term = 4, CreditID=20, Status="P"},
                    new Slot{SlotID = 11, DegreePlanID=7251, Term = 4, CreditID=555, Status="P"},
                    new Slot{SlotID = 12, DegreePlanID=7252, Term = 1, CreditID=664, Status="P"},
                    new Slot{SlotID = 13, DegreePlanID=7252, Term = 1, CreditID=64, Status="P"},
                    new Slot{SlotID = 14, DegreePlanID=7252, Term = 1, CreditID=10, Status="P"},
                    new Slot{SlotID = 15, DegreePlanID=7252, Term = 2, CreditID=691, Status="P"},
                    new Slot{SlotID = 16, DegreePlanID=7252, Term = 2, CreditID=555, Status="P"},
                    new Slot{SlotID = 17, DegreePlanID=7252, Term = 2, CreditID=618, Status="C"},
                    new Slot{SlotID = 18, DegreePlanID=7252, Term = 3, CreditID=460, Status="C"},
                    new Slot{SlotID = 19, DegreePlanID=7252, Term = 3, CreditID=542, Status="C"},
                    new Slot{SlotID = 20, DegreePlanID=7252, Term = 3, CreditID=691, Status="A"},
                     new Slot{SlotID =21, DegreePlanID=7252, Term = 4, CreditID=560, Status="C"},
                    new Slot{SlotID = 22, DegreePlanID=7252, Term = 4, CreditID=20, Status="C"},
                    new Slot{SlotID = 23, DegreePlanID=7252, Term = 4, CreditID=592, Status="C"},
                    new Slot{SlotID = 24, DegreePlanID=7253, Term = 1, CreditID=542, Status="P"},
                    new Slot{SlotID = 25, DegreePlanID=7253, Term = 1, CreditID=563, Status="P"},
                    new Slot{SlotID = 26, DegreePlanID=7253, Term = 1, CreditID=460, Status="P"},
                    new Slot{SlotID = 27, DegreePlanID=7253, Term = 2, CreditID=560, Status="A"},
                    new Slot{SlotID = 28, DegreePlanID=7253, Term = 2, CreditID=664, Status="A"},
                    new Slot{SlotID = 29, DegreePlanID=7253, Term = 2, CreditID=64, Status="A"},
                    new Slot{SlotID = 30, DegreePlanID=7253, Term = 3, CreditID=691, Status="A"},
                    new Slot{SlotID = 31, DegreePlanID=7253, Term = 3, CreditID=10, Status="A"},
                    new Slot{SlotID = 32, DegreePlanID=7253, Term = 3, CreditID=555, Status="A"},
                    new Slot{SlotID = 33, DegreePlanID=7253, Term = 4, CreditID=692, Status="C"},
                    new Slot{SlotID = 34, DegreePlanID=7253, Term = 4, CreditID=20, Status="C"},
                    new Slot{SlotID = 35, DegreePlanID=7253, Term = 4, CreditID=356, Status="C"},
                    new Slot{SlotID = 36, DegreePlanID=7254, Term = 1, CreditID=460, Status="P"},
                    new Slot{SlotID = 37, DegreePlanID=7254, Term = 1, CreditID=542, Status="P"},
                    new Slot{SlotID = 38, DegreePlanID=7254, Term = 1, CreditID=356, Status="P"},
                    new Slot{SlotID = 39, DegreePlanID=7254, Term = 2, CreditID=563, Status="C"},
                    new Slot{SlotID = 40, DegreePlanID=7254, Term = 2, CreditID=560, Status="C"},
                     new Slot{SlotID = 41, DegreePlanID=7254, Term = 2, CreditID=664, Status="C"},
                    new Slot{SlotID = 42, DegreePlanID=7254, Term = 3, CreditID=618, Status="A"},
                    new Slot{SlotID = 43, DegreePlanID=7254, Term = 3, CreditID=555, Status="A"},
                    new Slot{SlotID = 44, DegreePlanID=7254, Term = 2, CreditID=664, Status="A"},
                    new Slot{SlotID = 45, DegreePlanID=7254, Term = 4, CreditID=692, Status="P"},
                    new Slot{SlotID = 46, DegreePlanID=7254, Term = 4, CreditID=10, Status="P"},
                    new Slot{SlotID = 47, DegreePlanID=7254, Term = 4, CreditID=64, Status="P"},
                    new Slot{SlotID = 48, DegreePlanID=7255, Term = 1, CreditID=356, Status="C"},
                    new Slot{SlotID = 49, DegreePlanID=7255, Term = 1, CreditID=563, Status="C"},
                    new Slot{SlotID = 50, DegreePlanID=7255, Term = 1, CreditID=542, Status="C"},
                    new Slot{SlotID = 51, DegreePlanID=7255, Term = 2, CreditID=555, Status="C"},
                    new Slot{SlotID = 52, DegreePlanID=7255, Term = 2, CreditID=664, Status="C"},
                    new Slot{SlotID = 53, DegreePlanID=7255, Term = 2, CreditID=560, Status="C"},
                    new Slot{SlotID = 54, DegreePlanID=7255, Term = 3, CreditID=318, Status="A"},
                    new Slot{SlotID = 55, DegreePlanID=7255, Term = 3, CreditID=691, Status="A"},
                    new Slot{SlotID = 56, DegreePlanID=7255, Term = 4, CreditID=692, Status="P"},
                    new Slot{SlotID = 57, DegreePlanID=7255, Term = 4, CreditID=643, Status="P"},
                    new Slot{SlotID = 58, DegreePlanID=7255, Term = 4, CreditID=10, Status="P"},
                    new Slot{SlotID = 59, DegreePlanID=7255, Term = 5, CreditID=664, Status="P"},
                    new Slot{SlotID = 60, DegreePlanID=7256, Term = 1, CreditID=356, Status="A"},
                    new Slot{SlotID = 61, DegreePlanID=7256, Term = 1, CreditID=563, Status="A"},
                    new Slot{SlotID = 62, DegreePlanID=7256, Term = 1, CreditID=542, Status="A"},
                    new Slot{SlotID = 63, DegreePlanID=7256, Term = 2, CreditID=555, Status="P"},
                    new Slot{SlotID = 64, DegreePlanID=7256, Term = 2, CreditID=644, Status="P"},
                    new Slot{SlotID = 65, DegreePlanID=7256, Term = 2, CreditID=560, Status="P"},
                    new Slot{SlotID = 66, DegreePlanID=7256, Term = 3, CreditID=618, Status="P"},
                    new Slot{SlotID = 67, DegreePlanID=7256, Term = 3, CreditID=691, Status="P"},
                    new Slot{SlotID = 67, DegreePlanID=7256, Term = 3, CreditID=691, Status="P"},
                    new Slot{SlotID = 68, DegreePlanID=7256, Term = 4, CreditID=692, Status="P"},
                    new Slot{SlotID = 69, DegreePlanID=7256, Term = 4, CreditID=643, Status="P"},
                    new Slot{SlotID = 70, DegreePlanID=7256, Term = 5, CreditID=10, Status="P"},
                    new Slot{SlotID = 71, DegreePlanID=7256, Term = 5, CreditID=664, Status="P"},
                };
                Console.WriteLine($"Inserted {slots.Length} new slots.");

                foreach (Slot sl in slots)
                {
                    context.Slots.Add(sl);
                }

                context.SaveChanges();
            }


            //StudentTerm Table
            if (context.StudentTerms.Any())
            {
                Console.WriteLine("Student Term already exists");
            }
            else
            {
                var studentTerms = new StudentTerm[]
                {
                    new StudentTerm{StudentTermID = 1, StudentID=533569, StudentTermNo = 1, TermAbbrev="F18", TermName="Fall 2018"},
                    new StudentTerm{StudentTermID = 2, StudentID=533569, StudentTermNo = 2, TermAbbrev="S19", TermName="Spring 2019"},
                    new StudentTerm{StudentTermID = 3,StudentID=533569, StudentTermNo = 3, TermAbbrev="Su19", TermName="Summer 2019"},
                    new StudentTerm{StudentTermID = 4, StudentID=533569, StudentTermNo = 4, TermAbbrev="F19", TermName="Fall 2019"},
                    new StudentTerm{StudentTermID = 5, StudentID=533569, StudentTermNo = 5, TermAbbrev="S19", TermName="Spring 2019"},
                    new StudentTerm{StudentTermID = 6, StudentID=533982, StudentTermNo = 1, TermAbbrev="F18", TermName="Fall 2018"},
                    new StudentTerm{StudentTermID = 7, StudentID=533982, StudentTermNo = 2, TermAbbrev="S19", TermName="Spring 2019"},
                    new StudentTerm{StudentTermID = 8, StudentID=533982, StudentTermNo = 3, TermAbbrev="F19", TermName="Fall 2019"},
                    new StudentTerm{StudentTermID = 9, StudentID=533982, StudentTermNo = 4, TermAbbrev="S20", TermName="Spring 2020"},
                    new StudentTerm{StudentTermID = 10, StudentID=533982, StudentTermNo = 5, TermAbbrev="Su20", TermName="Summer 2020"},
                    new StudentTerm{StudentTermID = 11, StudentID=533573, StudentTermNo = 1, TermAbbrev="F18", TermName="Fall 2018"},
                    new StudentTerm{StudentTermID = 12, StudentID=533573, StudentTermNo = 2, TermAbbrev="S19", TermName="Spring 2019"},
                    new StudentTerm{StudentTermID = 13, StudentID=533573, StudentTermNo = 3, TermAbbrev="Su19", TermName="Summer 2019"},
                    new StudentTerm{StudentTermID = 14, StudentID=533573, StudentTermNo = 4, TermAbbrev="F19", TermName="Fall 2019"},
                    new StudentTerm{StudentTermID = 15, StudentID=533573, StudentTermNo = 5, TermAbbrev="S20", TermName="Spring 2020"}

                };
                Console.WriteLine($"Inserted {studentTerms.Length} new studentTerms.");

                foreach (StudentTerm stt in studentTerms)
                {
                    context.StudentTerms.Add(stt);
                }

                context.SaveChanges();
            }


        }
    }
}