using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using WebAPI.Models;
using System.Data.Entity;

namespace WebAPI.Controllers
{
    public class StudentsController : ApiController
    {
        StudentContext db = new StudentContext();

        // GET api/students
        public IEnumerable<Student> Get()
        {
            return db.Students;
        }

        // GET api/students/5
        public Student Get(int id)
        {
            Student student = db.Students.Find(id);
            return student;
        }

        // POST api/students
        public void Post([FromBody]Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        // PUT api/students/5
        public void Put(int id, [FromBody]Student student)
        {
            if (id == student.Id)
            {
                db.Entry(student).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE api/students/5
        public void Delete(int id)
        {
            Student student = db.Students.Find(id);
            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }
        }
    }
}
