using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.DataAccess.Abstracts
{
    public interface IBaseDal<T>
    {
       List<T> GetAll();
        public void Add(T entity);
        public void Delete(T entity);
        public void Update(T entity);
    }
}
