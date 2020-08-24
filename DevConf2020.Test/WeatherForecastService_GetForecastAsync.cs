using DevConf2020.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevConf2020Trial.Test
{
    public class WeatherForecastService_GetForecastAsync
    {
        private WeatherForecastService _weatherForecastService;
        [SetUp]
        public void Setup()
        {
            _weatherForecastService = new WeatherForecastService();
        }

        [Test]
        public void GetWeatherForecastTemperatureBasedOnDateTime()
        {
            const int CountResult = 10;


            Task<WeatherForecast[]> weatherForecast = _weatherForecastService.GetForecastAsync(DateTime.Now);

            IEnumerable<WeatherForecast> weatherForecasts = weatherForecast.Result;
            Assert.AreEqual(CountResult, weatherForecasts.Count());
        }
    }
}