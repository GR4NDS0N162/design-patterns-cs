using System;
using System.Collections.Generic;

namespace HamburgerBuilder
{
    internal class Hamburger
    {
        public const string BREAD_WHITE = "Белый хлеб";
        public const string BREAD_RYE = "Ржаной хлеб";

        public const string CUTLET_CHICKEN = "Куриная котлета";
        public const string CUTLET_PORK = "Свиная котлета";
        public const string CUTLET_BEEF = "Говяжья котлета";

        public const string SAUCE_CHEESE = "Сырный соус";
        public const string SAUCE_SWEET_AND_SOUR = "Кисло-Сладкий соус";
        public const string SAUCE_SALSA = "Соус Сальса";

        public const string VEGETABLES_CUCUMBERS = "Огурцы";
        public const string VEGETABLES_TOMATOES = "Помидоры";

        private List<string> ingredients = new List<string>();

        public void AddIngredient(string ingredient)
        {
            ingredients.Add(ingredient);
        }

        public void DisplayIngredients()
        {
            Console.WriteLine("Ингредиенты гамбургера:");
            foreach (string ingredient in ingredients)
            {
                Console.WriteLine("\t- " + ingredient);
            }
        }
    }
}
