using Core.Abstracts.IRepositories;
using Core.Concrete.Entities;
using Data.Contexts;
using Util.GenericRepository;

namespace Data.Repositories
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(CozyDb db) : base(db) { }
    }
}
