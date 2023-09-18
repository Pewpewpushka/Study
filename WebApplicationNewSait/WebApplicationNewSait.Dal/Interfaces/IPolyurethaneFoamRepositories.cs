using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationNewSait.Domain.Entity;

namespace WebApplicationNewSait.DAL.Interfaces
{
    public interface IPolyurethaneFoamRepositories:IBaseRepositories<PolyurethaneFoam>
    {
        PolyurethaneFoam GetByName(string name);
    }
}
