using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
   class Converter
    {

    }
    public static class TemperatureConverter
    {
        static TemperatureConverter()
        {
            Console.WriteLine("In Static constructor "+DateTime.Now.Millisecond);
        }
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            Console.WriteLine("In Static method "+DateTime.Now.Millisecond);
            // Convert argument to double for calculations.
            double celsius = Double.Parse(temperatureCelsius);

            // Convert Celsius to Fahrenheit.
            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            // Convert argument to double for calculations.
            double fahrenheit = Double.Parse(temperatureFahrenheit);

            // Convert Fahrenheit to Celsius.
            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
    }

    class TestTemperatureConverter
    {

    }
    /* Example Output:
        Please select the convertor direction
        1. From Celsius to Fahrenheit.
        2. From Fahrenheit to Celsius.
        :2
        Please enter the Fahrenheit temperature: 20
        Temperature in Celsius: -6.67
        Press any key to exit.
     */
}
