using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fahrenheitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature(Fahrenheit): ");
            float originalFahrenheit = float.Parse(Console.ReadLine());
            float Celsius = ((originalFahrenheit - 32)/9)*5;
            Console.WriteLine(originalFahrenheit + "degrees in Fahrenheit is" + Celsius + "degrees in Celsius");

            Console.WriteLine("Enter temperature(Celsius): ");
            float originalCelsius = float.Parse(Console.ReadLine());
            float Fahrenheit = ((originalCelsius * 9) / 5) + 32;

            Console.WriteLine(originalCelsius + "degrees in Celsius is" + Fahrenheit + "degrees in Fahrenheit");
        }
    }
}
