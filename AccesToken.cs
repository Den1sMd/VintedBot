using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinted_UK_Bot
{
    internal class AccesToken
    {
        public static async Task<string> getAccesToken()
        {
            string url = "https://www.vinted.co.uk/catalog";



            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/138.0.0.0 Safari/537.36");
                client.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
                client.DefaultRequestHeaders.Add("Accept-Language", "fr-FR,fr;q=0.9");

                HttpResponseMessage response = await client.GetAsync(url);

                


                if (response.Headers.TryGetValues("Set-Cookie", out var cookies))
                {
                    
                    foreach (var cookie in cookies)
                    {
                        
                        if (cookie.StartsWith("access_token_web"))
                        {
                            
                            
                            string[] parts = cookie.Split(';');
                            string accessTokenString = parts[0];
                            string accessTokenValue = accessTokenString.Split('=')[1];

                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine(" ");
                            }

                            

                            
                            return accessTokenValue;

                        }
                        
                        
                  
                    }
                    
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" ");
                }
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Problem dans le token contact askov");
                Console.ResetColor();
                return null;

            }

        }
    }
}
