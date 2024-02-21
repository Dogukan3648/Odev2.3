using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.Entities
{
    public class Course:BaseClass
    {
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

    }
}
