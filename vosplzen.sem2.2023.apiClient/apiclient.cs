using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vosplzen.sem2._2023.apiClient
{

    public class ApiClient : IDisposable
    {
        private HttpClient httpClient;

        public ApiClient()
        {
            httpClient = new HttpClient();
        }

        public async Task<bool> SendMessage(object message, string baseurl, string authToken)
        {
            try
            {

                var settings = new Newtonsoft.Json.JsonSerializerSettings() { Culture = new CultureInfo("en-US") };
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(message, settings);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                //var request = new HttpRequestMessage(HttpMethod.Post, );
                //request.Headers.Add("Authorization", authToken);                
                //request.Content = data;              

                //httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
                httpClient.DefaultRequestHeaders.Add("Authorization", authToken);

                var response = await httpClient.PostAsync($@"{baseurl}", data);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Message sent successfully.");
                    return true;

                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                
            }

            return false;
        }

        public void Dispose()
        {
            httpClient.Dispose();
        }
    }
}
