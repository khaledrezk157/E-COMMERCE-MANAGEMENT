using System.Drawing;

using System;
using E_COMMERCE_MANAGEMENT.APPDBCONTEXT;
using E_COMMERCE_MANAGEMENT.MOdels;
using E_COMMERCE_MANAGEMENT.Repos.interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace E_COMMERCE_MANAGEMENT.Repos.implemnt
{
    public class ProductRepo : GenericRepo<Product>, IProduct
    {
        private readonly Appdbcontext _context;
        public ProductRepo(Appdbcontext _context) : base(_context)
        {
            this._context = _context;
        }

       

       public  async Task<IEnumerable<Product>> Getpage1Async(int? catId, int size, int num, string sortby)
        {
            
            var e = _context.Products.AsQueryable();
            if (catId != null) { 
            
            e=e.Where(a=>a.categoryId== catId);
            }

            if (sortby.Contains("name"))
            {
                e.OrderBy(e => e.Name);
            }
            else if (sortby.Contains("price"))
            {
                e.OrderBy(e => e.Price);
            }
            var qu = e.Skip((num - 1) * size).Take(size);
            return await qu.ToListAsync();
        }

        public void save()
        {
            _context.SaveChangesAsync();
        }

        public async Task<Product> secondmostexpensiveexcluding(int id)
        {
           var m= _context.Products.Where(a=>a.categoryId==id).OrderBy(a=>a.Price).Skip(1).Take(1).FirstOrDefault();
            return m;
        }
    }
}
