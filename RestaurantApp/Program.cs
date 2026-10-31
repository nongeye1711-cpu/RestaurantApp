using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT.1/1");
            List<Restaurant> restaurants = new List<Restaurant>
{
    new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
    new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
    new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
    new Restaurant(4, "Huguosi Snak", "Snack",4.2),
    new Restaurant(5, "Haidilo Hot pot", "Hot Pot", 4.8)
};
foreach (var item in restaurants)
            {
                Console.WriteLine($"{item.Id}. {item.Name}. ({item.Category}) -Reting: {item.Rating}");
            }
            var amount = restaurants.Count();
            var avg = restaurants.Average(x => x.Rating);
            Console.WriteLine($"Total is {amount}");
            Console.WriteLine($"Average is {avg}");
            Console.WriteLine("==================================================");
           }
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Rating { get; set; }

        public Restaurant(int id, string name, string category, double rating)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Rating = rating;
        }


    }

}
