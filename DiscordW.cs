using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vinted_UK_Bot
{
    internal class DiscordWebhook
    {


        private static readonly string filePath = "webhook.txt";

        public static string saveUrl()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            string durl = null;


            if (File.Exists(filePath))
            {
                durl = File.ReadAllText(filePath);
            }


            if (string.IsNullOrWhiteSpace(durl))
            {
                Console.WriteLine("Rentre ton webhook Discord : \n");
                string urlClient = Console.ReadLine();
                durl = urlClient;
                File.WriteAllText(filePath, durl);
            }
            else
            {
                Console.WriteLine("Tu a déja un webhook discord veux tu l utilisé ou le changer ?\n");
                Console.WriteLine("1 : Changer\n");
                Console.WriteLine("2 : Refuser\n");
                string respC = Console.ReadLine();

                if (respC == "1")
                {
                    Console.WriteLine("Rentre un nouveau url : \n");
                    string newUrl = Console.ReadLine();
                    newUrl = durl;
                    File.WriteAllText(filePath, newUrl);
                }
                else
                {
                    Console.WriteLine("Pas de changement");
                }
            }

            Console.ResetColor();

            return durl;

            
        }
    }
}
