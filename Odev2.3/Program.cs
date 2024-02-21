using Odev2._3.Business.Concretes;
using Odev2._3.DataAccess;
using Odev2._3.DataAccess.Concrete;
using Odev2._3.Entities;

CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> courses = courseManager.GetAll();

foreach (var course in courses)
{
    Console.WriteLine("Kurs ID: " +course.Id);
    Console.WriteLine("Kurs Adı: "+course.CourseName);
    Console.WriteLine("Kategori ID: "+course.CategoryId);
    Console.WriteLine("Eğitmen ID: " +course.InstructorId);
    Console.WriteLine("Açıklama: " +course.Description);
    Console.WriteLine("****************");

}

courseManager.Add(new Course
{
    Id = 4,
    CategoryId = 2,
    CourseName = "Algoritmaya Giriş",
    Description = "Yazılım Geliştirmeyle Algoritma",
    InstructorId = 2
});

List<Course> addCourse = courseManager.GetAll();

foreach (var course in addCourse)
{
    Console.WriteLine("Kurs ID: " + course.Id);
    Console.WriteLine("Kurs Adı: " + course.CourseName);
    Console.WriteLine("Kategori ID: " + course.CategoryId);
    Console.WriteLine("Eğitmen ID: " + course.InstructorId);
    Console.WriteLine("Açıklama: " + course.Description);
    Console.WriteLine("****************");

}

    Console.WriteLine("\n##############################################\n");

courseManager.Delete(new Course { Id = 1 });

courseManager.Update(new Course { Id = 4 ,CourseName = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"});

List<Course> updateCourse = courseManager.GetAll();
foreach (var course in updateCourse)
{
    Console.WriteLine("KursID: " + course.Id);
    Console.WriteLine("EğitmenID: " + course.InstructorId);
    Console.WriteLine("KategoriID: " + course.CategoryId);
    Console.WriteLine("Kursİsmi: " + course.CourseName);
    Console.WriteLine("Açıklama: " + course.Description);
    Console.WriteLine("****************");

}

    Console.WriteLine("\n##############################################\n");

CategoryManager categoryManager = new CategoryManager(new CategoryDal());
List<Category> categories = categoryManager.GetAll();
foreach (var category in categories)
{
    Console.WriteLine("Kategori ID: " + category.Id);
    Console.WriteLine("Kategori Adı: " + category.CategoryName);
    Console.WriteLine("****************");

}

categoryManager.Add(new Category
{
    Id = 3,
    CategoryName = "Siber"
});

List<Category> categories2 = categoryManager.GetAll();
foreach (var category in categories2)
{
    Console.WriteLine("Kategori ID: " + category.Id);

    Console.WriteLine("Kategori Adı: " + category.CategoryName);
    Console.WriteLine("****************");
}

categoryManager.Update(new Category
{
    Id = 3,
    CategoryName = "Siber Güvenlik"
});

List<Category> updateCategory = categoryManager.GetAll();
foreach (var category in updateCategory)
{
    Console.WriteLine("Kategori ID: " + category.Id);
    Console.WriteLine("Kategori Adı: " + category.CategoryName);
    Console.WriteLine("****************");

}

categoryManager.Delete(new Category { Id = 3 });
List<Category> categories1 = categoryManager.GetAll();
foreach (var category in categories)
{
    Console.WriteLine("Kategori ID: " + category.Id);
    Console.WriteLine("Kategori Adı: " + category.CategoryName);
    Console.WriteLine("****************");



}

InstructorManager instructorManager = new InstructorManager(new InstructorDal());

List<Instructor> instructors = instructorManager.GetAll();
foreach (var instructor in instructors)
{
    Console.WriteLine("Eğitmen ID: " + instructor.Id);
    Console.WriteLine("Eğitmen Adı: " + instructor.FirstName);
    Console.WriteLine("Eğitmen Soyadı: " + instructor.LastName);
    Console.WriteLine("****************");
}

instructorManager.Add(new Instructor
{
    Id = 3,
    FirstName = "Doğukan",
    LastName = "Bozkır"
});

List<Instructor> addInstructor = instructorManager.GetAll();
foreach (var instructor in addInstructor)
{
    Console.WriteLine("Eğitmen ID: " + instructor.Id);
    Console.WriteLine("Eğitmen Adı: " + instructor.FirstName);
    Console.WriteLine("Eğitmen Soyadı: " + instructor.LastName);
    Console.WriteLine("****************");

}

instructorManager.Update(new Instructor
{
    Id = 3,
    FirstName = "Doğukan",
    LastName = "BOZKIR"
});

List<Instructor> updateInstructor = instructorManager.GetAll();
foreach (var instructor in updateInstructor)
{
    Console.WriteLine("EğitmenID: " + instructor.Id);
    Console.WriteLine("Eğitmen Adı: " + instructor.FirstName);
    Console.WriteLine("Eğitmen SoyAdı: " + instructor.LastName);
    Console.WriteLine("****************");

}

instructorManager.Delete(new Instructor { Id = 3 });
List<Instructor> deletedInstroctur = instructorManager.GetAll();

foreach (var instructor in deletedInstroctur)
{
    Console.WriteLine("Eğitmen ID: " + instructor.Id);
    Console.WriteLine("Eğitmen Adı: " + instructor.FirstName);
    Console.WriteLine("Eğitmen Soyadı: " + instructor.LastName);
    Console.WriteLine("****************");


}

Console.ReadKey();