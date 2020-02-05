using System;

namespace FluentAPINew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Fluent API====");

            using (var db = new TestContext())
            {
                for (int i = 0; i < 10; i++)
                {
                    db.Students.Add(new Student { Name = "stu" + i, Age = 20 + i });
                }
                db.SaveChanges();
            }

            
        }
    }
}
