using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.Business.Abstracts
{
    public interface ICourseManager
    {
        List<Course> GetAll();
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);

    }
}
