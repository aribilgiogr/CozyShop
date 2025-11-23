using Core.Abstracts.IRepositories;
using Core.Concrete.Entities;
using Data.Contexts;
using Util.GenericRepository;

namespace Data.Repositories
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(CozyDb db) : base(db) { }
    }
}
