using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Predefined variables
            string name = "Dawid";
            string city = "Sunderland";
            double money = 123.40;
            double temperature = 12.3;

            String sample = "Hello " + name + ". Today is: " + DateTime.Today.ToString("d");
            Console.WriteLine(sample);

            Console.WriteLine("---");

            sample = String.Format("Hello {0}. Today is: {1:d}", name, DateTime.Today);
            Console.WriteLine(sample);

            Console.WriteLine("---");

            sample = "Hello " + name + " Today is: " + DateTime.Today.ToString("d") + Environment.NewLine + "The temperature is: " +temperature.ToString() + " in " + city + Environment.NewLine + "You have: " + money.ToString("C") + " on your account" + Environment.NewLine + "Have a nice day " + name;
            Console.WriteLine(sample);

            Console.WriteLine("---");

            sample = String.Format("Hello {0}. Today is: {1:d}. \n The temperature is: {2} in {3:}.\n You have {4:C} on your account. \n Have a nice day {0}", name,DateTime.Today,temperature,city,money);
            Console.WriteLine(sample);

            Console.WriteLine("---");

            sample = "Now it's " + DateTime.Today.ToString("d") + " at " + DateTime.Today.ToString("t");
            Console.WriteLine(sample);

            Console.WriteLine("---");

            sample = String.Format("Now it's {0:d} at {0:t}", DateTime.Today);
            Console.WriteLine(sample);

            Console.WriteLine("---");

            int[] years = { 2013, 2014, 2015 };
            int[] population = { 1025632, 1105967, 1148203 };
            sample = String.Format("{0,-10} {1,-10}\n\n", "Year", "Population");
            for (int index = 0; index < years.Length; index++)
                sample += String.Format("{0,-10} {1,-10:N0}\n", years[index], population[index]);

            Console.WriteLine(sample);

            Console.WriteLine("---");

            sample = $"Hello {name}. Today is {DateTime.Today:d}";
            Console.WriteLine(sample);

            Console.WriteLine("---");

            Console.ReadKey();
        }
    }
}
