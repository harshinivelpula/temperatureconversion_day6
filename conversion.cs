using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatureconversiond6
{
    internal class conversion
    {
             static void main(String[] args)
            {
                AlgorithmUtility utility = new AlgorithmUtility();
                double temperatureinferenheit, temperatureincelcius;
                Scanner scanner = new(System.in);

                Console.WriteLine("Enter Temperature in Ferenheit : ");
                temperatureinferenheit = scanner.nextDouble();
                temperatureincelcius = utility.FahrenheitToCelsius(temperatureinferenheit);
                Console.WriteLine("Fahrenheit to Celcius of " + temperatureinferenheit + " is " + temperatureincelcius);

                Console.WriteLine("Enter Temperature in Celsius : ");
                temperatureincelcius = scanner.nextDouble();
                temperatureinferenheit = utility.CelsiusToFahrenheit(temperatureincelcius);
                Console.WriteLine("Celcius to Fahrenheit of " + temperatureincelcius + " is " + temperatureinferenheit);

                scanner.close();
             }
    }

        internal class Scanner
        {
            public Scanner(object value1, in object value2)
            {
                Value1 = value1;
                Value2 = value2;
            }

            public object Value1 { get; }
            public object Value2 { get; }

            internal void close()
            {
                throw new NotImplementedException();
            }

            internal double nextDouble()
            {
                throw new NotImplementedException();
            }
        }

        internal class AlgorithmUtility
        {
            internal double CelsiusToFahrenheit(double temperatureInCelcius)
            {
                throw new NotImplementedException();
            }

            internal double FahrenheitToCelsius(double temperatureInFerenheit)
            {
                throw new NotImplementedException();
            }
        }
}
