using System;
using ConsumeConversionService.ConverTemperarture;

namespace ConsumeConversionService
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertTemperatureClient client = new ConvertTemperatureClient();
            Console.WriteLine($" 45.0 degree celcius = {client.CelciusToFahrenheit(45.0M)} Fahrenheit");
            Console.Read();
        }
    }
}
