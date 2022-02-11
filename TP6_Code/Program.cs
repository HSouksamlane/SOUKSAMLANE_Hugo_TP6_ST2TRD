using System;
using System.Collections.Generic;

namespace TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza_Director director = new Pizza_Director();
            PizzaBuilder builder = new PizzaBuilder();

            //First pizza
            director.initializing_first_pizza(builder);
            Pizza first_pizza = builder.GetPizza();
            Console.WriteLine(first_pizza.ToString());

            //Second pizza
            director.initializing_second_pizza(builder);
            Pizza second_pizza = builder.GetPizza();
            Console.WriteLine(second_pizza.ToString());
             

            //Third pizza
            director.initializing_third_pizza(builder);
            Pizza third_pizza = builder.GetPizza();
            Console.WriteLine(third_pizza.ToString());
        }
    }
}
