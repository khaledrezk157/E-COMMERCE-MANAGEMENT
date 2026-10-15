using E_COMMERCE_MANAGEMENT.APPDBCONTEXT;
using E_COMMERCE_MANAGEMENT.MOdels;
using E_COMMERCE_MANAGEMENT.Repos.interfaces;

namespace E_COMMERCE_MANAGEMENT.Repos.implemnt
{
    public class unitOfWorkrepo : IUnitOfWork
    {
        private readonly Appdbcontext _context;

        public unitOfWorkrepo(Appdbcontext _context, IGenericRepo<Category> categoryss, IProduct productss, IOrder orderss, IGenericRepo<User> userss, IGenericRepo<OrderItem> oorderitemss)
        {
           this._context = _context;
            this.categoryss = categoryss;
            this.productss = productss;
            this.orderss = orderss;
            this.userss = userss;
            this.oorderitemss = oorderitemss;
        }

        public IGenericRepo<Category> categoryss { get; }

        public IProduct productss {get;}
        public IOrder orderss {get;}

        public IGenericRepo<User> userss { get; }

        public IGenericRepo<OrderItem> oorderitemss{ get; }

        public async Task save()
        {
          await _context.SaveChangesAsync();
        }
    }
}
