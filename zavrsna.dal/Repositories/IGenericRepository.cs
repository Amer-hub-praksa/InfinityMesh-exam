using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using zavrsna.dal.Domain;

namespace zavrsna.dal.Repositories
{
    public interface IGenericRepository<TEntitity> where TEntitity : BaseEntitity
    {

        TEntitity getById(int Id);
        Task<IReadOnlyCollection<TEntitity>> GetTopTen(CancellationToken cancellationToken = default);
        Task<TEntitity> AddObject(TEntitity obj, CancellationToken cancellationToken = default);
        void DeleteById(int Id);

    }
}