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
            string url = "https://www.vinted.fr/";



            using (HttpClient client = new HttpClient())
            {


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
                Console.WriteLine("Problem dans le acces token contact askov");
                Console.ResetColor();
                return null;

            }

        }


        public static async Task<string> getRefreshToken()
        {
            string url = "https://www.vinted.fr/";



            using (HttpClient client = new HttpClient())
            {


                HttpResponseMessage response = await client.GetAsync(url);






                if (response.Headers.TryGetValues("Set-Cookie", out var cookies))
                {

                    foreach (var cookie in cookies)
                    {

                        if (cookie.StartsWith("refresh_token_web"))
                        {


                            string[] parts = cookie.Split(';');
                            string accessTokenString = parts[0];
                            string refresh_token_web = accessTokenString.Split('=')[1];

                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine(" ");
                            }




                            return refresh_token_web;

                        }



                    }

                }

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" ");
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Problem dans le token refresh contact askov");
                Console.ResetColor();
                return null;

            }

        }
    }
}
