using Demo.Nothwind.Entities.Concrete;
using System.Collections.Generic;

namespace Demo.Nothwind.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}