using samplefirst.DataAccessLayer.Infrastructure.IRepository;
using samplefirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplefirst.DataAccessLayer.Infrastructure.Repository
{
    public class ProductRepository : Repository<TBL_Product>, IProductRepository<TBL_Product>
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(TBL_Product product)
        {
            var productDB = _context.Products.FirstOrDefault(x => x.ID == product.ID);
            if (productDB != null) 
            {
                productDB.Name = product.Name;
                productDB.Description = product.Description;
                productDB.Price = product.Price;
                productDB.ModifiedDate = DateTime.Now;
                productDB.CategoryID = product.CategoryID;
                if (product.ImageUrl != null)
                { 
                    productDB.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}
