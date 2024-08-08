using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplefirst.Models
{
    public class TBL_Product
    {
        [Key]
        public int ID { get; set; }
        /*[Required(ErrorMessage = "dnfihi")]*/
        /*[Display(Name ="Product Name")]*/
        [Required]
        /*[DataType(DataType.EmailAddress)] -- > aa nathi chaltu*/
        [EmailAddress]
        public string Name { get; set; }
        /*[StringLength(10)]*/
        [MaxLength(2)]
        [MinLength(2)]
        public string Description { get; set; }
        [Range(100, 1000, ErrorMessage = "Enter 100 to 1000")]
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public Category category { get; set; }
    }
}
