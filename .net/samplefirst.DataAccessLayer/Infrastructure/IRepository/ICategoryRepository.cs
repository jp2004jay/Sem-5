using samplefirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplefirst.DataAccessLayer.Infrastructure.IRepository
{
    public interface ICategoryRepository<T> : IRepository<Category>
    {
        void Update(Category category);
    }
}
