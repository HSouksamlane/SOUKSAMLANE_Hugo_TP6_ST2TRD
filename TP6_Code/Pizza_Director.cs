using System;
using System.Collections.Generic;
using System.Text;

namespace TP6
{
    class Pizza_Director
    {
        private Pizza_Builder builder;

        void initializingBuilder(Pizza_Builder builder)
        {
            this.builder = builder;
        }

        public void initializing_first_pizza(Pizza_Builder builder)
        {
            builder.setPizza_Size("Small");
            builder.setPizza_BaseSauce("Tomato sauce");
            builder.setPizza_DoughType("Thin");
            builder.setCheese("Yes");
            String[] Additionnal_Toppings = {"Oignon","Minced Beef"};
            builder.addTopping(Additionnal_Toppings);
        }

        public void initializing_second_pizza(Pizza_Builder builder)
        {
            builder.reset();

            builder.setPizza_Size("Big");
            builder.setPizza_BaseSauce("Cream");
            builder.setPizza_DoughType("Cheesy");
            builder.setCheese("Yes");
            String[] Additionnal_Toppings = {"Blue Cheese","Salmon", "Roasted Pork", "Mushroom"};
            builder.addTopping(Additionnal_Toppings);
        }

        public void initializing_third_pizza(Pizza_Builder builder)
        {
            builder.reset();
            builder.setPizza_Size("Medium");
            builder.setPizza_BaseSauce("None");
            builder.setPizza_DoughType("Thick");
            builder.setCheese("No");
            String[] Additionnal_Toppings = {};
            builder.addTopping(Additionnal_Toppings);
        }
    }
}
