using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerBuilder
{
    internal interface IHamburgerBuilder
    {
        void Reset();
        void AddBread(string ingredient);
        void AddCutlet(string ingredient);
        void AddSauce(string ingredient);
        void AddVegetables(string ingredient);
        Hamburger GetHamburger();
    }
}
