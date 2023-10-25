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

        public bool Create(Foam entity)
        {
            throw new NotImplementedException();
        }

        public Foam Get(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Foam GetByName(string name)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Foam> IBaseRepository<Foam>.SelectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Foam>> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
