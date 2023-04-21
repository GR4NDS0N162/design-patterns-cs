using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperUniqueDecorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductFactory factory = new ProductFactory();
            IProduct product1 = factory.CreateProduct("Товар 1");
            IProduct product2 = factory.CreateProduct("Товар 2");
            factory.PrintProducts();

            // Ждем подтверждения от пользователя
            Console.ReadLine();
        }
    }
}
