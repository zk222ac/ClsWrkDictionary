using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // List

            List<int> list = new List<int>();

            //// Dictionary

            Dictionary<string, string> objDictionary1 = new Dictionary<string, string>();

            objDictionary1.Add("1111", "Red");
            objDictionary1.Add("2222", "Green");
            objDictionary1.Add("3333", "Black");
            objDictionary1.Add("4444", "Yellow");

            foreach (var dic in objDictionary1)
            {
                string key = dic.Key;
                string value = dic.Value;
                Console.WriteLine($"The key is {key}, Value is {value}");
            }

            //Console.WriteLine("I want the specfic information.......... ");

            string key1 = Console.ReadLine();
            if (key1 != null)
            {
                string value1 = objDictionary1[key1];
                Console.WriteLine(value1);
            }

            // Object type Dictionary............................. 

            Dictionary<string, Car> objDictionary = new Dictionary<string, Car>
            {
                { "1111", new Car("1234", "Ferrari", "AB01") },
                { "2222", new Car("4567", "Audi", "AB02") },
                { "5555", new Car("6451", "mercedes", "AB03") },
                { "6666", new Car("8674", "honda", "AB04") }
            };

            foreach (var dic in objDictionary)
            {
                string key = dic.Key;
                Car car = dic.Value;

                Console.WriteLine($"The key is:{key}- Value is:{car.CVR}, {car.Name},{car.Model}");
            }
            Console.WriteLine("..................................................");
            Console.WriteLine("Enter the specific key for a particular car information");
            // I want to check the value of mercedes
            string keys = Console.ReadLine();
            while (keys != "stop")
            {
                if (keys != null && objDictionary.ContainsKey(keys))
                {
                    Car car = objDictionary[keys];
                    Console.WriteLine($"The name of Car : {car.Name}");
                }
                else
                {
                    Console.WriteLine("There is no information regarding this key");
                }
                Console.WriteLine("Enter the specific key for a particular car information");
                keys = Console.ReadLine();
            }

           Console.WriteLine("Program is end");

            Console.ReadKey();

        }
    }
}
