using E_COMMERCE_MANAGEMENT.MOdels;

namespace E_COMMERCE_MANAGEMENT.Repos.interfaces
{
    public interface IUnitOfWork
    {
        public IGenericRepo<Category> categoryss { get; }
        public IProduct productss { get; }
         public IOrder orderss { get; }
        public IGenericRepo<User> userss { get; }
        public IGenericRepo<OrderItem>oorderitemss { get; }

        Task save();
    
    }
}
