using Business;
using Business.Services;
using Core.Abstracts.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoMapperConfig.Initialize();
            IProductService service = new ProductService();
            var categories = service.GetAllCategories();
            if (categories.Count() > 0)
            {
                foreach (var item in categories)
                {
                    Console.WriteLine($"{item.Name} ({item.ProductCount})");
                }
            }
            else
            {
                Console.WriteLine("Category list is empty!");
            }
        }
    }
}
