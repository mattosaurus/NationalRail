using NationalRail.Models.HistoricalServicePerformance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace NationalRail
{
    public class HistoricalServicePerformanceClient
    {
        private readonly string _emailAddress;
        private readonly string _password;
        private readonly string _authorization;

        public HistoricalServicePerformanceClient(string emailAddress, string password)
        {
            _emailAddress = emailAddress;
            _password = password;
            _authorization = "Basic " + AppCode.Common.EncodeBas64String(emailAddress + ":" + password);
        }

        public async Task<ServiceMetricResponse> GetServiceMetrics(ServiceMetric serviceMetric)
        {
            string url = "https://hsp-prod.rockshore.net/api/v1/serviceMetrics";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", AppCode.Common.EncodeBas64String(_emailAddress + ":" + _password));
                client.DefaultRequestHeaders.Host = "hsp-prod.rockshore.net";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header

                // Ignore null values
                JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
                serializerSettings.NullValueHandling = NullValueHandling.Ignore;

                StringContent content = new StringContent(JsonConvert.SerializeObject(serviceMetric, Formatting.None, serializerSettings));
                content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                HttpResponseMessage response = await client.PostAsync(new Uri(url), content);

                response.EnsureSuccessStatusCode();
                ServiceMetricResponse serviceMetricResponse = JsonConvert.DeserializeObject<ServiceMetricResponse>(await response.Content.ReadAsStringAsync());

                return serviceMetricResponse;
            }
        }

        public async Task<ServiceDetailsResponse> GetServiceDetails(ServiceDetailsRID rid)
        {
            string url = "https://hsp-prod.rockshore.net/api/v1/serviceDetails";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", AppCode.Common.EncodeBas64String(_emailAddress + ":" + _password));
                client.DefaultRequestHeaders.Host = "hsp-prod.rockshore.net";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header

                // Ignore null values
                JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
                serializerSettings.NullValueHandling = NullValueHandling.Ignore;

                StringContent content = new StringContent(JsonConvert.SerializeObject(rid));
                content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                HttpResponseMessage response = await client.PostAsync(new Uri(url), content);

                response.EnsureSuccessStatusCode();
                ServiceDetailsResponse serviceAttributeDetailsResponse = JsonConvert.DeserializeObject<ServiceDetailsResponse>(await response.Content.ReadAsStringAsync());

                return serviceAttributeDetailsResponse;
            }
        }
    }
}
