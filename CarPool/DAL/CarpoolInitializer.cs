using CarPool.Models;
using System;
using System.Collections.Generic;

namespace Carpool.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CarpoolContext>
    {
        protected override void Seed(CarpoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var drivers = new List<Driver>
            {
            new Driver{DriverID=1050,CarInsurance=true,},
            new Driver{DriverID=4022,CarInsurance=true,},
            new Driver{DriverID=4041,CarInsurance=true,},
            new Driver{DriverID=1045,CarInsurance=true,},
            new Driver{DriverID=3141,CarInsurance=true,},
            new Driver{DriverID=2021,CarInsurance=true,},
            new Driver{DriverID=2042,CarInsurance=true,},
            };
            drivers.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var school = new List<School>
            {
            new School {SchoolID=1,},
            new School {SchoolID=2,},

            
            };
            school.ForEach(s => context.Schools.Add(5));
            context.SaveChanges();
        }
    }
}