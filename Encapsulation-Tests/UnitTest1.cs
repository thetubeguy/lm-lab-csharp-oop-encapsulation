using NUnit.Framework;
using Encapsulation.Models;
using FluentAssertions;

namespace Encapsulation_Tests
{
    public class Tests
    {   

        [Test]
        public void CapeTown_40_C()
        {
            string actualResult = new WeatherReporter("Cape Town", 40).GetWeather(false);
            string expectedResult = "I am in Cape Town and it is 🌤. It's too hot 🥵!. The temperature in Centigrade is 40.";
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void London_9_F()
        {
            string actualResult = new WeatherReporter("London", 9).GetWeather();
            string expectedResult = "I am in London and it is 🌦. It's too cold 🥶!. The temperature in Fahrenheit is 48.2.";
            actualResult.Should().Be(expectedResult);
        }

    }
}