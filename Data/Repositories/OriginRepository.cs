using Core.Abstracts.IRepositories;
using Core.Concrete.Entities;
using Data.Contexts;
using Util.GenericRepository;

namespace Data.Repositories
{
    public class OriginRepository : Repository<Origin>, IOriginRepository
    {
        public OriginRepository(CozyDb db) : base(db) { }
    }
}
