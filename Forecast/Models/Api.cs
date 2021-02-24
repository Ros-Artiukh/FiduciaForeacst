using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Forecast.Models
{
        public class Main
        {
            public string Temp_min {get;set;}
            public string Temp_max { get; set; }
        }

        public class Weather
        {
            public string Main { get; set; }
        }

        public class SeparatorResponse
        {
            public List<Weather> Weather { get; set; }
            public Main Main { get; set; }
        }

        public class Api
        {
            public async Task<SeparatorResponse> getForecast(string city) {
                var client = new HttpClient();
                var url = $"api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid=c43b508482520a8beaf781d2f0ff750c";
                var response = await client.GetAsync($"http://{url}");
                string json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<SeparatorResponse>(json);
                return result;
            }
       
        }
}
