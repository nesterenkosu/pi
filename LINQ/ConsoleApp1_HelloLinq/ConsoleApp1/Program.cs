using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = {"Челябинск","Барселона","Бавария","Берлин","Чебоксары" };

            /*var selectedCities = from city in cities
                                 where city.StartsWith("Ч")
                                 orderby city //descending
                                 select city;
            */

            var selectedCities = cities.Where(city => city.StartsWith("Ч")).OrderByDescending(city=>city);

            foreach (string city in selectedCities)
                Console.WriteLine(city);

            Console.ReadLine();
        }
    }
}
