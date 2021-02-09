using System;
using System.Linq;
using System.Collections.Generic;

public class Item
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public Item(string name, int price, int qty)
    {
        Name = name;
        Price = price;
        Quantity = qty;
    }
}

namespace StoneProject
{
    class StoneChallenge
    {
        public static void Main()
        {
            List<Item> items = new List<Item>();
            List<string> emails = new List<string>();

            //New items template. Adding directly to the above variable "items"
            items.Add(new Item("Mechanical Keyboard", 10000, 1));
            items.Add(new Item("Smart TV", 90005, 3));
            items.Add(new Item("iPhone", 20000, 3));

            //New emails template. Adding directly to the above variable "emails"
            emails.Add("alexandre@email.com");
            emails.Add("leandro@email.com");
            emails.Add("gustavo@email.com");

            var result = GetOrderValues(items, emails);

            if (result != null) { 
                foreach (var i in result){
                    Console.WriteLine("Key: " + i.Key + " Value: " + i.Value);
                }
            } else {
                Console.WriteLine("There are no values on the list.");
            }
        }
        /// <summary>
        /// Calculate the final price of the order, according to the provided items and emails.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="emails"></param>
        /// <returns>Returns a dictionary with emails and prices divided by each person.</returns>
        public static Dictionary<string, int> GetOrderValues(List<Item> items, List<string> emails){
            
            var res = new Dictionary<string, int>();

            var emailsQty = emails.Count();
            var total = 0;

            if (emailsQty == 0) { 
                Console.WriteLine("The e-mail list is empty!");
                return null;
            }

            if (items.Count() == 0) {
                Console.WriteLine("The item list is empty!");
                return null;
            }

            foreach (var item in items)
                total += item.Price * item.Quantity;

            var valuePerPerson = (int)(total/emailsQty);

            var leftover = (int)total % emailsQty; 

            foreach(var em in emails){
                if (leftover > 0) {
                    res.Add(em, valuePerPerson + 1);
                    leftover -= 1;
                } else {
                    res.Add(em, valuePerPerson);
                }
            }

            return res;
        }

    }
}


