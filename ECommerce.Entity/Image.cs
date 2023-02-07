using ECommerce.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity
{
    public class Image : BaseEntity
    {
        public string Url { get; set; }
        public string Base64Url { get; set; }
        public int? ProductId { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public Product? Product { get; set; }



    }
}
