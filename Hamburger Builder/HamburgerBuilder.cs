﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerBuilder
{
    internal class HamburgerBuilder : IHamburgerBuilder
    {
        private Hamburger hamburger;

        public void Reset()
        {
            Console.WriteLine("Создаем новый гамбургер");
            hamburger = new Hamburger();
        }

        public void AddBread(string ingredient)
        {
            Console.WriteLine("Добавляем хлеб: " + ingredient);
            hamburger.AddIngredient(ingredient);
        }

        public void AddCutlet(string ingredient)
        {
            Console.WriteLine("Добавляем котлету: " + ingredient);
            hamburger.AddIngredient(ingredient);
        }

        public void AddSauce(string ingredient)
        {
            Console.WriteLine("Добавляем соус: " + ingredient);
            hamburger.AddIngredient(ingredient);
        }

        public void AddVegetables(string ingredient)
        {
            Console.WriteLine("Добавляем овощи: " + ingredient);
            hamburger.AddIngredient(ingredient);
        }

        public Hamburger GetHamburger()
        {
            return hamburger;
        }
    }
}