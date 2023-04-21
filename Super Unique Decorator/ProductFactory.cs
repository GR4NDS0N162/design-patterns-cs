using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperUniqueDecorator
{
    internal class ProductFactory
    {
        private List<IProduct> products = new List<IProduct>();

        public IProduct CreateProduct(string title)
        {
            IProduct product = new Product(title);
            products.Add(product);
            products.Add(new SuperProductDecorator(product));
            products.Add(new UniqueProductDecorator(product));
            products.Add(new SuperUniqueProductDecorator(product));
            return product;
        }

        public void PrintProducts()
        {
            foreach (IProduct product in products)
            {
                Console.WriteLine(product.GetTitle());
            }
        }
    }
}
