using System;
using System.Collections.Generic;
using System.Text;

namespace TP6
{
    interface Pizza_Builder
    {
        void setPizza_Size(string pizza_size) { }
        void setPizza_BaseSauce(string base_sauce) { }
        void setPizza_DoughType(string dough_type) { }
        void setCheese(string cheese) { }
        void addTopping(string[] topping) { }
        void reset() { }

    }
}
