using E_COMMERCE_MANAGEMENT.MOdels;

namespace E_COMMERCE_MANAGEMENT.Repos.interfaces
{
    public interface IProduct:IGenericRepo<Product>
    {
        Task<IEnumerable<Product>> Getpage1Async(int? catId,int size, int num,string sortby);
        Task<Product> secondmostexpensiveexcluding(int id);
        void save();
    }
}
