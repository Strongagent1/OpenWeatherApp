using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace OpenWeatherApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            var apiKey = JObject.Parse(key).GetValue("DefaultKey").ToString();

            Console.WriteLine("Pleae entet a zip code where you would like to check the weather.");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={apiKey}&units=imperial";
            
            Console.WriteLine($"Thank you the current temperature is {WeatherMap.GetTemp(apiCall)}F");
        }
    }
}