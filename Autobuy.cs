using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Vinted_UK_Bot
{
    internal class Autobuy
    {



        public static async Task<string> login(string accestoken)
        {
            Console.WriteLine("Entre ton token : ");
            string token = Console.ReadLine();
            Console.Clear();


            string url = "https://www.vinted.fr/settings/account";



            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/140.0.0.0 Safari/537.36");
                client.DefaultRequestHeaders.Add("Cookie", $"access_token_web={accestoken}; refresh_token_web={token}");

                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);

                return responseBody;


            }


        }
    }
}
