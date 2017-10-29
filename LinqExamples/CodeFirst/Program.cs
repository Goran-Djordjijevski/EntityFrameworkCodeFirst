using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                Student student = new Student()
                {
                    StudentName = "Goran"
                };

                db.Students.Add(student);
                db.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}
