using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperUniqueDecorator
{
    internal abstract class ProductDecorator : IProduct
    {
        protected IProduct product;

        public ProductDecorator(IProduct product)
        {
            this.product = product;
        }

        public abstract string GetTitle();
    }
}
