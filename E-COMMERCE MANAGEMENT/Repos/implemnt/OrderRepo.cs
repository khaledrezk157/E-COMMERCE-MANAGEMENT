using E_COMMERCE_MANAGEMENT.APPDBCONTEXT;
using E_COMMERCE_MANAGEMENT.MOdels;
using E_COMMERCE_MANAGEMENT.Repos.interfaces;

namespace E_COMMERCE_MANAGEMENT.Repos.implemnt
{
    public class OrderRepo : GenericRepo<Order>,IOrder
    {
        private readonly Appdbcontext _context;
        public OrderRepo(Appdbcontext _context) : base(_context)
        {this._context = _context;
        }
    }
}
