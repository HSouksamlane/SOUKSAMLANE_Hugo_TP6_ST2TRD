using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace TP6
{
    class PizzaBuilder : Pizza_Builder
    {
        private Pizza pizza;

        public PizzaBuilder() { this.pizza = new Pizza(); }
     
        void Pizza_Builder.setPizza_Size(string Pizza_Size)
        {
            pizza.initializing_PizzaSize(Pizza_Size);
        }

        void Pizza_Builder.setPizza_BaseSauce(string Base_Sauce)
        {
            pizza.Initializing_BaseSauce(Base_Sauce);
        }

        void Pizza_Builder.setPizza_DoughType(string Dough_Type)
        {
            pizza.Initializing_DoughType(Dough_Type);
        }
        void Pizza_Builder.setCheese(string Cheese)
        {
            pizza.Initializing_Cheese(Cheese);
        }

        void Pizza_Builder.addTopping(string []Additionnal_Topping)
        {
            pizza.Initializing_AdditionnalTopping(Additionnal_Topping);
        }

        void Pizza_Builder.reset()
        {
            this.pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            return this.pizza;
        }

    }
}
