using DeliTrack.Application.Repositories;
using DeliTrack.Domain.Entities;
using DeliTrack.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTrack.Persistence.Repositories;

public class StoreRepository : BaseRepository<Store>, IStoreRepository
{
    public StoreRepository(DataContext context) : base(context) { }
}