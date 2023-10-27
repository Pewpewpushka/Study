using Microsoft.EntityFrameworkCore;
using PPUmarket.DAL.Interfaces;
using PPUmarket.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PPUmarket.DAL.Repositories
{
    public class FoamRepository : IFoamRepository
    {
        private readonly ApplicationDbContext _db;

        public FoamRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(Foam entity)
        {
            await _db.Foam.AddRangeAsync();
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<Foam> Get(int id)
        {
            return await _db.Foam.FirstOrDefaultAsync(x=> x.Id == id);
        }
        //public async Task<IEnumerable<Foam>> Select()
        //{
        //    return await _db.Foam.ToListAsync();
        //}

        public async Task<List<Foam>> Select()
        {
            return await _db.Foam.ToListAsync();
        }
        public bool Delete(Foam entity)
        {
            _db.Foam.Remove(entity);
            _db.SaveChangesAsync();
            return true;
        }

        public async Task<Foam> GetByNameAsync(string name)
        {
            return await _db.Foam.FirstOrDefaultAsync(x => x.Name == name);
        }

        IEnumerable<Foam> IBaseRepository<Foam>.SelectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Foam>> ToListAsync()
        {
            throw new NotImplementedException();
        }

        Foam IFoamRepository.GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        Foam IBaseRepository<Foam>.Get(int id)
        {
            throw new NotImplementedException();
        }

        bool IBaseRepository<Foam>.Create(Foam entity)
        {
            throw new NotImplementedException();
        }

        public Task GetByName(string v)
        {
            throw new NotImplementedException();
        }
    }
}
