using Odev2._3.Business.Abstracts;
using Odev2._3.DataAccess.Abstracts;
using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.Business.Concretes
{
    public class CourseManager:ICourseManager
    {
        private readonly ICourseDal _courseDal;


        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }



        public void Delete(Course course)
        {
            _courseDal.Delete(course);

        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }
    }
}
