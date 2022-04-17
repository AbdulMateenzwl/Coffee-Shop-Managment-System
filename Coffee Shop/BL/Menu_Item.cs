using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop.BL
{
    internal class Menu_Item
    {
        public string name;
        public string type;
        public float price;
        public Menu_Item(string name,int choice,float price)
        {
            this.name = name;
            this.price = price;
            if(choice == 1)
            {
                type = "drink";
            }
            else if(choice == 2)
            {
                type = "food";
            }
            else
            {
                type = "food";
            }
        }
    }
}
