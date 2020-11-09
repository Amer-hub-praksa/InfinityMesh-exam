using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using zavrsna.dal.Domain;

namespace zavrsna.dal
{
    class zavrsnaDbContext
    {
        internal DbSet<BaseEntitity> Set<T>()
        {
            throw new NotImplementedException();
        }

        internal Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
