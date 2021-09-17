using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebAPIClient;

namespace dev12222
{
    class Program
    {
        


        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false"),
            };

            var streamTask = client.GetStreamAsync("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false");
            var criptos = await JsonSerializer.DeserializeAsync<List<CriptoAsset>>(await streamTask);

            Console.WriteLine(criptos);
            foreach (var cripto in criptos)
            {
                Console.WriteLine(cripto.symbol);
                Console.WriteLine(cripto.name);
                Console.WriteLine(cripto.current_price);
                Console.WriteLine(cripto.market_cap);
                Console.WriteLine(cripto.market_cap_rank);
                
            }
            

        }
    }
}
