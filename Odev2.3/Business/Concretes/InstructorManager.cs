using Odev2._3.Business.Abstracts;
using Odev2._3.DataAccess.Abstracts;
using Odev2._3.DataAccess.Concrete;
using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.Business.Concretes
{
    public class InstructorManager:IInstructorManager
    {
        private readonly IInstructorsDal _instructorManager;

        public InstructorManager(IInstructorsDal instructorDal)
        {
            _instructorManager = instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorManager.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorManager.Delete(instructor);
        }

        public void Update(Instructor instructor)
        {
            _instructorManager.Update(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorManager.GetAll();
        }
    }
}
