using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperUniqueDecorator
{
    internal class SuperUniqueProductDecorator : ProductDecorator
    {
        public SuperUniqueProductDecorator(IProduct product) : base(product) { }

        public override string GetTitle()
        {
            return "Супер Неповторимый " + product.GetTitle();
        }
    }
}
