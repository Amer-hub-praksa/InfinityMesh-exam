using zavrsna.dal;
using zavrsna.dal.Domain;
using zavrsna.dal.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace zavrsna.dal.Repositories
{
    public class GenericRepository<TEntitity> : IGenericRepository<TEntitity> where TEntitity : BaseEntitity
    {
        private zavrsnaDbContext _Context;
        private DbSet<TEntitity> Table;

        public GenericRepository(DbContext context)
        {
            _Context = context;
            Table = _Context.Set<TEntitity>();
        }
        public async Task<TEntitity> AddObject(TEntitity obj, CancellationToken cancellationToken = default)
        {
            await Table.AddAsync(obj);
            await _Context.SaveChangesAsync(cancellationToken);
            return obj;
        }

        public async Task<IReadOnlyCollection<TEntitity>> GetTopTen(CancellationToken cancellationToken = default)
        {
            int MaxNum = 10;
            return await Table.Take(MaxNum).ToListAsync(cancellationToken);
        }

        public TEntitity getById(int Id)
        {
            return Table.Find(Id);
        }

        public void DeleteById(int Id)
        {
            TEntitity Obj = Table.Find(Id);
            Table.Remove(Obj);

        }
    }
}
