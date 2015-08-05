using System.Collections.Generic;
using AngularWebAPIPagination.Models;

namespace AngularWebAPIPagination.ViewModels
{

    public class ProductListJsonViewModel
    {
        public int PageCount { get; set; }
        public int TotalItems { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}