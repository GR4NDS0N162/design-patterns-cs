using System.Collections.Generic;

namespace HamburgerBuilder
{
    internal class HamburgerDirector
    {
        private IHamburgerBuilder hamburgerBuilder;
        private List<Hamburger> storage = new List<Hamburger>();

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

            storage.Add(hamburgerBuilder.GetHamburger());
        }
    }
}
