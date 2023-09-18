using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationNewSait.DAL.Interfaces;
using WebApplicationNewSait.Domain.Entity;


namespace WebApplicationNewSait.DAL.Repositories
{
    public class PolyurethaneFoamRepositories : IPolyurethaneFoamRepositories

    {
        private readonly ApplicationDbContext _db;
        public PolyurethaneFoamRepositories(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(PolyurethaneFoam entity)
        {
            throw new NotImplementedException();
        }
        public PolyurethaneFoam Get(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<PolyurethaneFoam> Select()
        {
            return (IEnumerable<PolyurethaneFoam>)_db.PolyurethaneFoam.ToListAsync();
        }

        public bool Delete(PolyurethaneFoam entity)
        {
            throw new NotImplementedException();
        }


        public PolyurethaneFoam GetByName(string name)
        {
            throw new NotImplementedException();
        }

    }
}
