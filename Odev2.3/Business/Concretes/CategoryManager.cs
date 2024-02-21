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
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryDal _categoryManager;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryManager = categoryDal;

        }

        public void Add(Category category)
        {
            _categoryManager.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryManager.Delete(category);

        }
        public void Update(Category category)
        {
            _categoryManager.Update(category);
        }

        public List<Category> GetAll()
        {
            return _categoryManager.GetAll();
        }


    }
}
