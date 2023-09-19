using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationNewSait.DAL.Interfaces
{
    public interface IBaseRepositories<T>
    {
        bool Create(T entity);
        T Get(int id);
        Task<IEnumerable<T>> Select();
        bool Delete(T entity);
    }
}
