using System;
using System.Collections.Generic;
using System.Text;

namespace TP6
{
    public class Pizza
    {
        private string Pizza_Size;
        private string Base_Sauce;
        private string Dough_Type;
        private string Cheese;
        private string[] Additionnal_Topping;

        public void initializing_PizzaSize(string Pizza_Size)
        {
            this.Pizza_Size = Pizza_Size;
        }

        public void Initializing_BaseSauce(String Base_Sauce)
        {
            this.Base_Sauce = Base_Sauce;
        }

        public void Initializing_DoughType(String Dough_Type)
        {
            this.Dough_Type = Dough_Type;
        }
        public void Initializing_Cheese(String Cheese)
        {
            this.Cheese = Cheese;
        }

        public void Initializing_AdditionnalTopping(String[] Additionnal_Topping)
        {
            this.Additionnal_Topping = Additionnal_Topping;
        }

        override
        public String ToString()
        {
            String output = "-Pizza description :\n\nSize = " + Pizza_Size + "\nBase sauce = " + Base_Sauce + "\nDough type = " + Dough_Type + "\nCheese = " + Cheese;

            if (Additionnal_Topping.Length != 0)
            {
                output += "\nAdditionnal Toppings : ";

                foreach (var Topping in Additionnal_Topping)
                {
                    output += Topping + " ";
                }
            }
            return output + "\n";
        }
    }
}
