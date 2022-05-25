using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
enum Escale
{
    Celsius,
    Fahrenheit,
    Kelvin

};

namespace Temperature1
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature1 = new Temperature(30, Escale.Celsius);
            Temperature temperature2 = new Temperature(50, Escale.Kelvin);

            Temperature result = temperature2.Add(temperature1);

            Console.WriteLine(result.magnitude);

            Console.ReadLine();
        }
    }

    class Temperature
    {
       public float magnitude;
        public Escale escale;
        public Temperature(float magnitude, Escale escala)
        {
            this.magnitude = magnitude;
            this.escale = escala;
        }

        public Temperature Convert(Temperature temperature)
        {
            if(this.escale == Escale.Celsius)
            {
                temperature.ToCelcius();
                return temperature;
            }
            else if(this.escale == Escale.Fahrenheit)
            {
                temperature.ToFahrenheit();
                return temperature;
            }
            else
            {
                temperature.ToKelvin();
                return temperature;
            }
        }

        public Temperature Add(Temperature temperature)
        {
            if(this.escale == temperature.escale)
            {
                float result = this.magnitude + temperature.magnitude;

                Temperature temperatureReturn = new Temperature(result, this.escale);

                return temperatureReturn;
            }
            else
            {
               Temperature newTemperature = this.Convert(temperature);

                float result = this.magnitude + newTemperature.magnitude;

                Temperature temperatureToReturn = new Temperature(result, this.escale);

                return temperatureToReturn;
            }
        }

        public Temperature Substract(Temperature temperature)
        {
            if (this.escale == temperature.escale)
            {
                float result = this.magnitude - temperature.magnitude;

                Temperature temperatureReturn = new Temperature(result, this.escale);

                return temperatureReturn;
            }
            else
            {
                Temperature newTemperature = this.Convert(temperature);

                float result = this.magnitude - newTemperature.magnitude;

                Temperature temperatureToReturn = new Temperature(result, this.escale);
                return temperatureToReturn;
            }
        }

        public Temperature MultiplyBy(Temperature temperature)
        {
            if (this.escale == temperature.escale)
            {
                float result = this.magnitude * temperature.magnitude;

                Temperature temperatureReturn = new Temperature(result, this.escale);

                return temperatureReturn;
            }
            else
            {
                Temperature newTemperature = this.Convert(temperature);

                float result = this.magnitude * newTemperature.magnitude;

                Temperature temperatureToReturn = new Temperature(result, this.escale);

                return temperatureToReturn;
            }
        }

        public Temperature DivideBy(Temperature temperature)
        {
            if (this.escale == temperature.escale)
            {
                float result = this.magnitude / temperature.magnitude;

                Temperature temperatureReturn = new Temperature(result, this.escale);

                return temperatureReturn;
            }
            else
            {
                Temperature newTemperature = this.Convert(temperature);

                float result = this.magnitude / newTemperature.magnitude;

                Temperature temperatureToReturn = new Temperature(result, this.escale);

                return temperatureToReturn;
            }
        }

        public Temperature ToCelcius()
        {

            if(this.escale == Escale.Fahrenheit)
            {
                this.magnitude = (this.magnitude - 32) / 1.8f;
            }
            else
            {
                this.magnitude -= 273.15f;
            }
            
            
            this.escale = Escale.Celsius;

            return this;
        }

        public Temperature ToFahrenheit()
        {

            if (this.escale == Escale.Celsius)
            {
                this.magnitude = (this.magnitude * 1.8f) + 32;
            }
            else
            {
                this.magnitude = (this.magnitude - 273.15f) * 1.8f + 32;
            }

            this.escale = Escale.Fahrenheit;

            return this;
        }

        public Temperature ToKelvin()
        {

            if (this.escale == Escale.Celsius)
            {
                this.magnitude += 273.15f;
            }
            else
            {
                this.magnitude = (this.magnitude - 32) / 1.8f + 273;
            }

            this.escale = Escale.Fahrenheit;

            return this;
        }
    }

    
}
