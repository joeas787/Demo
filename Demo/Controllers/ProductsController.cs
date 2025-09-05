using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class ProductsController : Controller
    {
        public string Get(int id)
        {
            return $"hello from {id}";
        }

        public string Create(int id,string name,Product product)
        {
            return $"hello from {id} ,{name}\n {product.Id},{product.Name}";
        }

    }
}
