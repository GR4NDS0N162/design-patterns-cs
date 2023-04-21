using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerBuilder
{
    internal class HamburgerDirector
    {
        private IHamburgerBuilder hamburgerBuilder;

        public HamburgerDirector(IHamburgerBuilder hamburgerBuilder)
        {
            this.hamburgerBuilder = hamburgerBuilder;
        }

        public void MakeHamburger()
        {
            hamburgerBuilder.Reset();
            hamburgerBuilder.AddBread(Hamburger.BREAD_WHITE);
            hamburgerBuilder.AddSauce(Hamburger.SAUCE_CHEESE);
            hamburgerBuilder.AddVegetables(Hamburger.VEGETABLES_TOMATOES);
            hamburgerBuilder.AddCutlet(Hamburger.CUTLET_CHICKEN);
            hamburgerBuilder.AddVegetables(Hamburger.VEGETABLES_CUCUMBERS);
            hamburgerBuilder.AddBread(Hamburger.BREAD_WHITE);
        }
    }
}
