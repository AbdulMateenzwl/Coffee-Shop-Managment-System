using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_Shop.BL;
using Coffee_Shop.DL;
namespace Coffee_Shop.UI
{
    internal class Ui
    {
        public static char menu()
        {
            Console.WriteLine("1) Add Menu Item");
            Console.WriteLine("2) View the cheapest item in the Menu");
            Console.WriteLine("3) View the Drinks Menu");
            Console.WriteLine("4) View the Food Menu");
            Console.WriteLine("5) Add Order");
            Console.WriteLine("6) Fulfil the Order");
            Console.WriteLine("7) View the orders list");
            Console.WriteLine("8) Total Payable Amount");
            Console.WriteLine("9) EXIT");
            Console.Write("Enter any option ...");
            char op = Console.ReadLine()[0];
            return op;
        }
        public static Menu_Item Add_item()
        {
            Console.WriteLine("Enter the name of Item : ");
            string name=Console.ReadLine();
            Console.WriteLine("1) Drink");
            Console.WriteLine("2) Food");
            Console.Write("Enter the type of item : ");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter the price : ");
            float price=float.Parse(Console.ReadLine());
            Menu_Item input = new Menu_Item(name, choice, price);
            return input;
        }
        public static Menu_Item add_Order()
        {
            Console.Write("Enter the name of Product : ");
            string name = Console.ReadLine();
            int index=Crud_menu.give_index(name);
            if( index== -1)
            {
                Console.WriteLine("The Product Is not available .");
            }
            else
            {
                Console.WriteLine("Item has been ordered .");
                return Crud_menu.coffee_shop.items[index];  
            }
            return null;
        }
        public static void show_drinks(List<Menu_Item> items)
        {
            Console.WriteLine("Name\tPrice");
            for (int i = 0; i < items.Count; i++)
            {
                if( items[i].type =="drink")
                {
                    Console.WriteLine(items[i].name+"\t"+items[i].price);
                }
            }
        }
        public static void show_food(List<Menu_Item> items)
        {
            Console.WriteLine("Name\tPrice");
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].type == "food")
                {
                    Console.WriteLine(items[i].name + "\t" + items[i].price);
                }
            }
        }
        public static void display_all(List<Menu_Item> items)
        {
            Console.WriteLine("Name\tPrice");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].name+"\t"+ items[i].price);
            }
        }
        public static void display_minimum(Menu_Item min)
        {
            Console.WriteLine("The Item with minimum Price "+min.price+" is "+min.name+" .");
        }
        public static void show_orders()
        {
            if(Crud_menu.check_orders())
            {
                Console.WriteLine("The Item is ready .");
                Crud_menu.coffee_shop.orders.Clear();
            }
            else
            {
                Console.WriteLine("All the orders have been fulfiled .");
            }
        }
        public static void display_orders(List<Menu_Item> orders)
        {
            Console.WriteLine("Name\tPrice");
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine(orders[i].name+"\t"+orders[i].price);
            }
        }
        public static void display_total(float total)
        {
            Console.WriteLine("The total amount is "+total+" .");
        }
    }
}
