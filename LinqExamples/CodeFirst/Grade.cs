using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Grade
    {
        public Grade()
        {

        }

        public int GradeId { get; set; }

        public string GradeName { get; set; }

        // Relationship
        public ICollection<Student> Students { get; set; }
    }
}
