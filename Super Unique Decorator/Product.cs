using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperUniqueDecorator
{
    internal class Product : IProduct
    {
        private string title;

        public Product(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return title;
        }
    }
}
