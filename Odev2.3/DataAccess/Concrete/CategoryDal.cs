using Odev2._3.DataAccess.Abstracts;
using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public CategoryDal()
        {
            Category category1 = new Category();
            category1.Id = 1;
            category1.CategoryName = "Yazılım";


            Category category2 = new Category();
            category2.Id = 2;
            category2.CategoryName = "Bilişim";

            _categories = new List<Category> {category1,category2 };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
            Console.WriteLine("Kategori Eklendi");
        }

        public void Delete(Category category)
        {
            var deletedCategory = _categories.First(category => category.Id == category.Id);
            _categories.Remove(deletedCategory);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            var updatedCategory = _categories.First(c => c.Id == category.Id);
            updatedCategory.Id = category.Id;
            updatedCategory.CategoryName = category.CategoryName;
        }
    }
}
