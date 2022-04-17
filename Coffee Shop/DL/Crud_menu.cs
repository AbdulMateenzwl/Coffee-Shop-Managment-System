using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_Shop.UI;
using Coffee_Shop.BL;

namespace Coffee_Shop.DL
{
    internal class Crud_menu
    {
        public static Coffee_shop coffee_shop = new Coffee_shop();
        public static List<Menu_Item> get_items()
        {
            return coffee_shop.items;
        }
        public static void add_item(Menu_Item input)
        {
            coffee_shop.items.Add(input);
        }
        public static void add_order(Menu_Item input)
        {
            coffee_shop.orders.Add(input);
        }
        public static int give_index(string str)
        {
            for (int i = 0; i < coffee_shop.items.Count; i++)
            {
                if (str == coffee_shop.items[i].name)
                {
                    return i;
                }
            }
            return -1;
        }
        public static Menu_Item Cheapest()
        {
            float price = 0f;
            int index = 0;
            for (int i = 0; i < coffee_shop.items.Count; i++)
            {
                if (price > coffee_shop.items[i].price)
                {
                    price=coffee_shop.items[i].price;
                    index = i;
                }
            }
            return coffee_shop.items[index];
        }
        public static bool check_orders()
        {
            if(coffee_shop.orders.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Menu_Item> get_orders()
        {
            return coffee_shop.orders;
        }
        public static float get_total()
        {
            float count = 0;
            for (int i = 0; i < coffee_shop.orders.Count; i++)
            {
                count = count + coffee_shop.orders[i].price;
            }
            return count;
        }
    }
}
