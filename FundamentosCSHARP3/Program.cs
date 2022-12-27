using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using FundamentosCSHARP.Models;
using FundamentosCSHARP3.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;


namespace FundamentosCSHARP3
{
    class Program
    {
        static async Task Main(string[] args)
        {
           string url = "https://jsonplaceholder.typicode.com/posts/50/99";
            var client = new HttpClient();

            Post post = new Post()
            {
                userId = 50,
                body = "Hola que tal",
                title = "titulo principal"
            };

            var data = JsonSerializer.Serialize<Post>(post);
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await client.PutAsync(url, content);

            if(httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<Post>(result);
            }
        }


    }
}