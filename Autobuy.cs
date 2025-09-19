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

        public static Task<string> token1 = AccesToken.getAccesToken();



        public static async Task<string> login()
        {
            Console.WriteLine("Entre ton mail vinted : ");
            string mail = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Entre ton motdepasse vinted : ");
            string pass = Console.ReadLine();
            Console.Clear();




            string url = "https://www.vinted.fr/web/api/auth/oauth";

            var payload = new
            {
                client_id = "web",
                scope = "user",
                username = mail,
                password = pass,
                fingerprint = "61935c98cb5e3d03cf79296b97a8e865",
                grant_type = "password"
            };


            string json = JsonSerializer.Serialize(payload);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");


            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/140.0.0.0 Safari/537.36");
                client.DefaultRequestHeaders.Add("Cookie", "datadome=1o7Z_l0erux3MGcxedfqb7pjss6s3qaVYsaYdugpH~5ubr~gt5sJUpns4d9s6_FQFVyYJbkmJbHPjTwYJsU8D5Dxz7BdL4YGxVrQI6KkTPnsWcCrrbErcTo3skmkZtvx");

                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);


               


                return responseBody;


            }


        }
    }
}
