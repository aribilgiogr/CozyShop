using Core.Abstracts;
using Core.Abstracts.IRepositories;
using Data.Contexts;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CozyDb db;
        public UnitOfWork()
        {
            db = new CozyDb();
        }

        private IAddressRepository addressRepository;
        public IAddressRepository AddressRepository => addressRepository = addressRepository ?? new AddressRepository(db);

        private ICartItemRepository cartItemRepository;
        public ICartItemRepository CartItemRepository => cartItemRepository = cartItemRepository ?? new CartItemRepository(db);

        private ICartRepository cartRepository;
        public ICartRepository CartRepository => cartRepository = cartRepository ?? new CartRepository(db);

        private ICategoryRepository categoryRepository;
        public ICategoryRepository CategoryRepository => categoryRepository = categoryRepository ?? new CategoryRepository(db);

        private ICoffeeBeanRepository coffeeBeanRepository;
        public ICoffeeBeanRepository CoffeeBeanRepository => coffeeBeanRepository = coffeeBeanRepository ?? new CoffeeBeanRepository(db);

        private ICouponRepository couponRepository;
        public ICouponRepository CouponRepository => couponRepository = couponRepository ?? new CouponRepository(db);

        private ICustomerRepository customerRepository;
        public ICustomerRepository CustomerRepository => customerRepository = customerRepository ?? new CustomerRepository(db);

        private IEquipmentRepository equipmentRepository;
        public IEquipmentRepository EquipmentRepository => equipmentRepository = equipmentRepository ?? new EquipmentRepository(db);

        private IOrderRepository orderRepository;
        public IOrderRepository OrderRepository => orderRepository = orderRepository ?? new OrderRepository(db);

        private IOrderItemRepository orderItemRepository;
        public IOrderItemRepository OrderItemRepository => orderItemRepository = orderItemRepository ?? new OrderItemRepository(db);

        private IOriginRepository originRepository;
        public IOriginRepository OriginRepository => originRepository = originRepository ?? new OriginRepository(db);

        private IPaymentRepository paymentRepository;
        public IPaymentRepository PaymentRepository => paymentRepository = paymentRepository ?? new PaymentRepository(db);

        private IProductRepository productRepository;
        public IProductRepository ProductRepository => productRepository = productRepository ?? new ProductRepository(db);

        private IReviewRepository reviewRepository;
        public IReviewRepository ReviewRepository => reviewRepository = reviewRepository ?? new ReviewRepository(db);

        private IShipmentRepository shipmentRepository;
        public IShipmentRepository ShipmentRepository => shipmentRepository = shipmentRepository ?? new ShipmentRepository(db);

        public void Commit()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Dispose();
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
