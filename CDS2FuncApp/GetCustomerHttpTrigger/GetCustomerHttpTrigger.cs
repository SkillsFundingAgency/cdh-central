
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using CDS2FuncApp.Services;

namespace CDS2FuncApp
{
    public static class GetCustomerHttpTrigger
    {
        [FunctionName("customer")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("Customer HTTP trigger function processed a request.");

            var service = new GETService();
            var values = await service.GetCustomers();

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(JsonConvert.SerializeObject(values),
                                            System.Text.Encoding.UTF8, "application/json")
            };
        }


    }
}
