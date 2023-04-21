using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем строителя и директора
            IHamburgerBuilder hamburgerBuilder = new HamburgerBuilder();
            HamburgerDirector hamburgerDirector = new HamburgerDirector(hamburgerBuilder);

            // Создаем гамбургер
            hamburgerDirector.MakeHamburger();
            Hamburger hamburger = hamburgerBuilder.GetHamburger();

            // Добавляем гамбургер в список созданных объектов
            List<Hamburger> hamburgers = new List<Hamburger>();
            hamburgers.Add(hamburger);

            // Выводим на экран ингредиенты гамбургера
            hamburger.DisplayIngredients();

            // Ждем подтверждения от пользователя
            Console.ReadLine();
        }
    }
}
