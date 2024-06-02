using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCRUD
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetValue(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
