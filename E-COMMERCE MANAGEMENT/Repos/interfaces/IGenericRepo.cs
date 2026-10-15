namespace E_COMMERCE_MANAGEMENT.Repos.interfaces
{
    public interface IGenericRepo<T> where T : class 
    {
        Task<IEnumerable<T>> Getall();
        Task Create(T obj);
        void Delete(int id);
        Task<T> GetById(int id);
        void Update(T obj,int id);

    }
}
