using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using XamWorkshop.Models;

namespace XamWorkshop.Services {
    internal class SwapiService {

        private string _baseUrl { get; set; }

        public SwapiService() {
            _baseUrl = "http://swapi.co/api/";
        }
        public async Task<MoviesResponse> GetFilms() {
            MoviesResponse response = new MoviesResponse();
            try {
                Debug.WriteLine("Get films");
                var requestUrl = string.Format("{0}films/", _baseUrl);
                using (var client = new HttpClient()) {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var resultString = await client.GetStringAsync(requestUrl);
                    response = JsonConvert.DeserializeObject<MoviesResponse>(resultString);
                    return response;
                }
            } catch {
                return null;
            }
            return response;

        }
    }
}
