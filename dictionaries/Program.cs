using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Dictionary<string, double>();

            inventory.Add("figs", 56);
            inventory.Add("apples", 23);
            inventory.Add("bananas", 10);

            var keys = inventory.Keys;
            Console.WriteLine("number of items: " + keys.Count);

            foreach (var key in keys)
            {
                Console.WriteLine(key + ": " + inventory[key]);
            }

            string[] keysArray = keys.ToArray();
            Array.Sort(keysArray);

            foreach (var key in keysArray)
            {
                Console.WriteLine(key + ": " + inventory[key]);
            }

            double value;
            if (inventory.TryGetValue("figs", out value))
            {
                Console.WriteLine("You have " + value + " figs");
            }
            else
            {
                Console.WriteLine("No figs");
            }
        }
    }
}
