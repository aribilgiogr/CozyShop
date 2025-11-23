using Core.Abstracts.IRepositories;
using Core.Concrete.Entities;
using Data.Contexts;
using Util.GenericRepository;

namespace Data.Repositories
{
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        public PaymentRepository(CozyDb db) : base(db) { }
    }
}
