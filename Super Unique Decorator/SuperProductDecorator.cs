using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperUniqueDecorator
{
    internal class SuperProductDecorator : ProductDecorator
    {
        public SuperProductDecorator(IProduct product) : base(product) { }

        public override string GetTitle()
        {
            return "Супер " + product.GetTitle();
        }
    }
}
