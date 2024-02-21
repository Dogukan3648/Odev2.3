using Odev2._3.DataAccess.Abstracts;
using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.DataAccess.Concrete
{
    public class CourseDal:ICourseDal
    {
        List<Course> _courses;

        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.CourseName = "C# + Angular";
            course1.InstructorId = 1;
            course1.CategoryId = 1;
            course1.Description = "Yazılım Geliştirici C# ve Angular Kampı";


            Course course2 = new Course();
            course2.Id = 2;
            course2.CourseName = "Java + React";
            course2.InstructorId = 1;
            course2.CategoryId = 1;
            course2.Description = "Yazılım Geliştirici JAVA ve React Kampı";


            Course course3 = new Course();
            course3.Id = 3;
            course3.CourseName = "Python";
            course3.InstructorId = 2;
            course3.CategoryId = 2;
            course3.Description = "Yazılım Geliştirici Python ve Selenium Kampı";


            _courses = new List<Course> {course1,course2,course3 };
        }

        public void Add(Course course)
        {
            _courses.Add(course);
            Console.WriteLine("Kurs Başarıyla Eklendi");
        }

        public void Delete(Course course)
        {
            var deletedCourse = _courses.First(c => c.Id == course.Id);
            _courses.Remove(deletedCourse);
            Console.WriteLine("Kurs Başarıyla Silindi");

        }

        public List<Course> GetAll()
        {
            return _courses;
        }

      

        public void Update(Course course)
        {
            var updatedCourse = _courses.FirstOrDefault(c => c.Id == course.Id);
            if (updatedCourse != null)
            {
                updatedCourse.CourseName = course.CourseName;
                updatedCourse.InstructorId = course.InstructorId;
                updatedCourse.CategoryId = course.CategoryId;
                updatedCourse.Description = course.Description;
                Console.WriteLine("Kurs Başarıyla Güncellendi");
            }
            else
            {
                Console.WriteLine("Güncellenecek kurs bulunamadı.");
            }
        }
    }
}
