using E_COMMERCE_MANAGEMENT.APPDBCONTEXT;
using E_COMMERCE_MANAGEMENT.Repos.interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_COMMERCE_MANAGEMENT.Repos.implemnt
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly Appdbcontext _context;
        public GenericRepo(Appdbcontext _context)
        {
            this._context = _context;
        }
        public async Task Create(T obj)
        {
            await _context.Set<T>().AddRangeAsync(obj);
           
        }

        public async void  Delete(int id)
        {
          var del=await _context.Set<T>().FindAsync(id);
          
            _context.Set<T>().Remove(del);
          
        
        }

        public async Task<IEnumerable<T>> Getall()
        {
            var get = await _context.Set<T>().ToListAsync();
            return get;
          
        
        }

        public async Task<T> GetById(int id)
        {
        var e= await _context.Set<T>().FindAsync(id);

            return e;
        }

        public  async void Update(T obj, int id)
        {
            var e =  await _context.Set<T>().FindAsync(id);
             _context.Set<T>().Update(obj);
        }
    }
}
