using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperUniqueDecorator
{
    internal class UniqueProductDecorator : ProductDecorator
    {
        public UniqueProductDecorator(IProduct product) : base(product) { }

        public override string GetTitle()
        {
            return "Неповторимый " + product.GetTitle();
        }
    }
}
