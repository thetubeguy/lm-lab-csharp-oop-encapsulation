using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        const int TooHot = 30;
        const int TooCold = 10;

        private readonly string _location;
        private readonly double _temperature_in_C;

        public WeatherReporter(string location, double temperature_in_C)
        {
            _location = location;
            _temperature_in_C = temperature_in_C;
        }

  
        public string GetWeather(bool Use_F_Scale)
        {
 
            if(Use_F_Scale)
                return ($"I am in {_location} and it is {Get_Weather_Conditions(_location)}. {How_Is_The_Temperature()}. The temperature in Fahrenheit is {Convert_To_Fahrenheit(_temperature_in_C)}.");
            else
                return ($"I am in {_location} and it is {Get_Weather_Conditions(_location)}. {How_Is_The_Temperature()}. The temperature in Centigrade is {_temperature_in_C}.");
        }


        public string GetWeather()
        {
            return GetWeather(true);
        }

        private static double Convert_To_Fahrenheit(double temp_in_C)
        {
            return (9.0 / 5.0) * temp_in_C + 32;
         
        }

        private static string Get_Weather_Conditions(string location)
        {
            if (location == "London")
            {

                return "🌦";

            }
            else if (location == "California")
            {

                return "🌅";

            }
            else if (location == "Cape Town")
            {

                return "🌤";

            }
            return "🔆";
        }

        private string How_Is_The_Temperature()
        {
            if (_temperature_in_C > TooHot)
            {

                return "It's too hot 🥵!";

            }
            else if (_temperature_in_C < TooCold)
            {

                return "It's too cold 🥶!";

            }
            return "Ahhh...it's just right 😊!";
        }

    }
}

