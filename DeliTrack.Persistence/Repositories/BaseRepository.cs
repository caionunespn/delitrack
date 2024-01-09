using DeliTrack.Application.Repositories;
using DeliTrack.Domain.Common;
using DeliTrack.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    protected readonly DataContext Context;

    public BaseRepository(DataContext context)
    {
        Context = context;
    }


    public void Create(T entity)
    {
        Context.Add(entity);
    }

    public void Update(T entity)
    {
        Context.Update(entity);
    }

    public void Delete(T entity)
    {
        Context.Remove(entity);
    }

    public Task<T> Get(Guid id,  CancellationToken cancellationToken)
    {
        return Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
        return Context.Set<T>().ToListAsync(cancellationToken);
    }
}