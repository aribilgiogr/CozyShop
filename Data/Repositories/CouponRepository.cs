using Core.Abstracts.IRepositories;
using Core.Concrete.Entities;
using Data.Contexts;
using Util.GenericRepository;

namespace Data.Repositories
{
    public class CouponRepository : Repository<Coupon>, ICouponRepository
    {
        public CouponRepository(CozyDb db) : base(db) { }
    }
}
