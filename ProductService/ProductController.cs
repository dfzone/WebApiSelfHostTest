using ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ProductService
{

    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        ProductDC dc = new ProductDC();

        [Route("GetProduct")]
        [HttpGet]
        public Goods GetProduct()
        {
            return dc.Set<Goods>().FirstOrDefault();
        }
    }
}
