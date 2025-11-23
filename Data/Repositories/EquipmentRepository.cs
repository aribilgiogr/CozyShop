using Core.Abstracts.IRepositories;
using Core.Concrete.Entities;
using Data.Contexts;
using Util.GenericRepository;

namespace Data.Repositories
{
    public class EquipmentRepository : Repository<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(CozyDb db) : base(db) { }
    }
}
