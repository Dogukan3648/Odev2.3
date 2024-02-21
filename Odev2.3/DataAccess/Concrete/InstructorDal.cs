using Odev2._3.DataAccess.Abstracts;
using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.DataAccess.Concrete
{
    public class InstructorDal:IInstructorsDal
    {
        List<Instructor> _instructor;

        public InstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.FirstName = "Engin";
            instructor1.LastName = "Demiroğ";

            Instructor instructor2 = new Instructor();
            instructor2.Id = 2;
            instructor2.FirstName = "Halit Enes";
            instructor2.LastName = "Kalaycı";

            _instructor = new List<Instructor> { instructor1,instructor2};
        }

        public void Add(Instructor instructor)
        {
            _instructor.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
           var deletedInstructors = _instructor.First(i=>i.Id == instructor.Id);
            _instructor.Remove(deletedInstructors);
        }

        public List<Instructor> GetAll()
        {
            return _instructor;
        }

    

        public void Update(Instructor instructor)
        {
            var updatedInstructors = _instructor.First(i=>i.Id==instructor.Id);
            updatedInstructors.Id = instructor.Id;
            updatedInstructors.FirstName = instructor.FirstName;
            updatedInstructors.LastName = instructor.LastName;
        }
    }
}
