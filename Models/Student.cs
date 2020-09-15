using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebProjectCRUD.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int contactNumber { get; set; }
        public string Address { get; set; }

    }
    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}