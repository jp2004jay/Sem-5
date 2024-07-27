using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplefirst.Models.ViewModels
{
    public class ProductViewModel
    { 
        public TBL_Product product { get; set; }
        public IEnumerable<TBL_Product> products { get; set; } = new List<TBL_Product>();
        public IEnumerable<Category> categories { get; set; } = new List<Category>();
    }
}
