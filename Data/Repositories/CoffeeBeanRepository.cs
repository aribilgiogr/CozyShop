using Core.Abstracts.IRepositories;
using Core.Concrete.Entities;
using Data.Contexts;
using Util.GenericRepository;

namespace Data.Repositories
{
    public class CoffeeBeanRepository : Repository<CoffeeBean>, ICoffeeBeanRepository
    {
        public CoffeeBeanRepository(CozyDb db) : base(db) { }
    }
}
