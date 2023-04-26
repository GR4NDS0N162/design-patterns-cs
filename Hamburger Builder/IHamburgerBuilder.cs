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
