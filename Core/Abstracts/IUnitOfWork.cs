using Core.Abstracts.IRepositories;
using System;

namespace Core.Abstracts
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepository AddressRepository { get; }
        ICartItemRepository CartItemRepository { get; }
        ICartRepository CartRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ICoffeeBeanRepository CoffeeBeanRepository { get; }
        ICouponRepository CouponRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        IEquipmentRepository EquipmentRepository { get; }
        IOrderRepository OrderRepository { get; }
        IOrderItemRepository OrderItemRepository { get; }
        IOriginRepository OriginRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        IProductRepository ProductRepository { get; }
        IReviewRepository ReviewRepository { get; }
        IShipmentRepository ShipmentRepository { get; }
        void Commit();
    }
}
