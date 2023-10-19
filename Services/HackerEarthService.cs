using HackerearthDesktop.Infrastructure.Common;
using HackerearthDesktop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using HackerearthDesktop.Models;
using System.Diagnostics;

namespace HackerearthDesktop.Services
{
    class HackerEarthService : Interfaces.IHackerEarthService
    {
        private HttpClient httpClient = new HttpClient();
        private const string _BASE_URL = "https://api.hackerearth.com/v4/partner/code-evaluation/submissions/";
        private const string _API_KEY = Api.ApiKey;
       


        public HackerEarthService()
        {
            httpClient.BaseAddress = new Uri(_BASE_URL);
            httpClient.DefaultRequestHeaders.Add("client-secret", _API_KEY);

        }

        public async Task<object> SubmitCode(string lang,
                                string source,
                                string input = "",
                                int memoryLimit = 256,
                                byte timeLimit = 1 )
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, httpClient.BaseAddress);
            var content = JsonConvert.SerializeObject(new
            {
                lang = lang,
                source = source,
                input = input,
                memoryLimit = memoryLimit,
                timeLimit = timeLimit
            });
            request.Content = new StringContent(content, Encoding.UTF8, "application/json");
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return JsonConvert.DeserializeObject<SubmitResponse>(result);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
            else
            {              
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ErrorResponse>(result);              
            }
            return null;
        }

        public Task<SubmitResponse> GetStatus(string statusUpdateUrl)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, statusUpdateUrl);
            var response = httpClient.SendAsync(request).Result.Content.ReadAsStringAsync().Result;
            return Task.FromResult(JsonConvert.DeserializeObject<SubmitResponse>(response));
        }

        public string GetOutput(string outputUrl)
        {
            return new HttpClient()
                .SendAsync(new HttpRequestMessage(HttpMethod.Get, outputUrl))
                .Result
                .Content
                .ReadAsStringAsync()
                .Result;
           
        }
    }
}
