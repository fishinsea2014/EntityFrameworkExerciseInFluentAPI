using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentAPINew
{
    public class TestContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; DataBase=FluentAPI; Trusted_connection=true; MultipleActiveResultSets=true");
        }

        public DbSet<Student> Students { get; set; }

           
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get;set; }
    }
}
