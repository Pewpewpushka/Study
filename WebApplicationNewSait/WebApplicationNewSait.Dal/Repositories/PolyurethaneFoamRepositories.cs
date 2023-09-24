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
        public async Task<bool> Create(PolyurethaneFoam entity)
        {
            await _db.PolyurethaneFoam.AddAsync(entity);
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<PolyurethaneFoam> Get(int id)
        {
            return await _db.PolyurethaneFoam.FirstOrDefaultAsync(x => x.Id == id);
        }
       public async Task<IEnumerable<PolyurethaneFoam>> Select()
        {
            return await _db.PolyurethaneFoam.ToListAsync();
        }

        public async Task<bool> Delete(PolyurethaneFoam entity)
        {
             _db.PolyurethaneFoam.Remove(entity);
            await _db.SaveChangesAsync();
            return true;
        }


        public async Task<PolyurethaneFoam> GetByNameAsync(string name)
        {
            return await _db.PolyurethaneFoam.FirstOrDefaultAsync(x => x.Name == name);
        }

        PolyurethaneFoam IBaseRepositories<PolyurethaneFoam>.Get(int id)
        {
            throw new NotImplementedException();
        }

        PolyurethaneFoam IPolyurethaneFoamRepositories.GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        bool IBaseRepositories<PolyurethaneFoam>.Create(PolyurethaneFoam entity)
        {
            throw new NotImplementedException();
        }

        bool IBaseRepositories<PolyurethaneFoam>.Delete(PolyurethaneFoam entity)
        {
            throw new NotImplementedException();
        }
    }
}
