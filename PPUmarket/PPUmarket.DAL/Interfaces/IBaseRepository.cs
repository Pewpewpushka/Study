using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUmarket.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Create (T entity);

        T Get (int id);

        IEnumerable<T> SelectAsync();

        bool Delete (T entity);


    }
}
