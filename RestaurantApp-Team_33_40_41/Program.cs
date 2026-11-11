using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team_33_40_41
{
    class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
    }

    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant>
    {
        new Restaurant { Name = "Shabushi", Type = "Buffet Shabu", Rating = 4.5 },
        new Restaurant { Name = "Pizza Hut", Type = "Pizza", Rating = 4.3 },
        new Restaurant { Name = "Bar B Q Plaza", Type = "BBQ", Rating = 4.6 },
        new Restaurant { Name = "Yayoi", Type = "Japanese", Rating = 4.4 },
        new Restaurant { Name = "S&P", Type = "Thai Food", Rating = 4.1 },
        new Restaurant { Name = "Chester's", Type = "Grilled Chicken", Rating = 4.8 },
    };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        ShowGoodRating();
                        break;
                    case "3":
                        ShowSummary();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // คน A รับผิดชอบ
        static void AddRestaurant()
        {
            Console.WriteLine("\n===== Restaurant List =====");

            foreach (var restaurant in restaurants)
            {
                Console.WriteLine("Restaurant Name: " + restaurant.Name);
                Console.WriteLine("Restaurant Type: " + restaurant.Type);
                Console.WriteLine("Restaurant Rating: " + restaurant.Rating);
                Console.WriteLine("---------------------------");
            }
        }

            // คน B รับผิดชอบ
            static void ShowGoodRating()
        {
            Console.WriteLine("\n===== Good Rating Restaurants (4.5++) =====");

            var goodRestaurants = restaurants
                .Where(r => r.Rating >= 4.5)
                .ToList();

            if (goodRestaurants.Count == 0)
            {
                Console.WriteLine("No restaurants with rating 4.5 or above.");
            }
            else
            {
                foreach (var restaurant in goodRestaurants)
                {
                    Console.WriteLine(
                        $"Name: {restaurant.Name}, Type: {restaurant.Type}, Rating: {restaurant.Rating}");
                }
            }
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {

            Console.WriteLine("\n===== Restaurant Summary =====");

            int total = restaurants.Count;

            if (total == 0)
            {
                Console.WriteLine("No restaurants available.");
                return;
            }

            double averageRating = restaurants.Average(r => r.Rating);

            var highestRating = restaurants
                .OrderByDescending(r => r.Rating)
                .First();

            Console.WriteLine($"Total Restaurants: {total}");
            Console.WriteLine($"Average Rating: {averageRating:F2}");
            Console.WriteLine($"Highest Rating: {highestRating.Name}");
            Console.WriteLine($"Rating: {highestRating.Rating}");

        }
    }
}
        

