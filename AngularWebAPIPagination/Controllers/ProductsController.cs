using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using AngularWebAPIPagination.Helpers;
using AngularWebAPIPagination.Models;
using AngularWebAPIPagination.ViewModels;

namespace AngularWebAPIPagination.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductsController()
        {
            _applicationDbContext = new ApplicationDbContext();
        }


        public async Task<ProductListJsonViewModel> GetProductByPage(int page, int pageSize)
        {

            var totalRecord = await _applicationDbContext.Products.CountAsync();
            var totalPage = PageCount.Count(totalRecord, pageSize);
            var products = await _applicationDbContext.Products
                                .OrderBy(p => p.Id)
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToListAsync();

            return new ProductListJsonViewModel
            {
                PageCount = totalPage,
                TotalItems = totalRecord,
                Products = products
            };

        }
    }
}
