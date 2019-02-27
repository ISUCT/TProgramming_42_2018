using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAPI.Models
{
    public class StudentDbInitializer : DropCreateDatabaseAlways<StudentContext>
    {
        protected override void Seed(StudentContext db)
        {
            db.Students.Add(new Student { Name = "Гусев Д.", Age = 19, Course = 2, Group = 42 });
            db.Students.Add(new Student { Name = "Войтович О.", Age = 13, Course = 2, Group = 42 });

            base.Seed(db);
        }
    }
}