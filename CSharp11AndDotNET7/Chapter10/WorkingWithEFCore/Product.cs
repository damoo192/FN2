using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithEFCore
{
    public class Product
    {

        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }
        [Column(TypeName = "NTEXT")]
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
