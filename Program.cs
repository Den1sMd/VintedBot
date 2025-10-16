using System;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Vinted_UK_Bot;
using static System.Runtime.InteropServices.JavaScript.JSType;




public class VintedCatalog
{
    public List<Item> items { get; set; }
}

public class Item
{
    public string url { get; set; }
    public Price price { get; set; }
    public Photo photo { get; set; }
    public string title { get; set; }
    public long id { get; set; }
}

public class Price
{
    public string amount { get; set; }

    public string currency_code { get; set; }
}

public class Photo
{
    public long id { get; set; }
    public string url { get; set; }
}





class Program
{

    public static string PrixMaximum;

    private static string nomdedom;

    private static string keyword;

    private static string hwidI;

    private static string hwidhash;

    private static string sec2;
    
    private static string sec3;

    public static int timeout;



    static async Task Main(string[] args)
    {

        hwidI = Security.hwid();
        hwidhash = Security.hashHwid1();

        sec3 = Security.sec3(hwidhash);

        if (sec3 == "suc")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string forvisual = @$"$$\    $$\ $$\            $$\                     $$\       $$\                  $$\           
$$ |   $$ |\__|           $$ |                    $$ |      $$ |                 $$ |          
$$ |   $$ |$$\ $$$$$$$\ $$$$$$\    $$$$$$\   $$$$$$$ |      $$$$$$$\   $$$$$$\ $$$$$$\         
\$$\  $$  |$$ |$$  __$$\\_$$  _|  $$  __$$\ $$  __$$ |      $$  __$$\ $$  __$$\\_$$  _|        Version : 2.5
 \$$\$$  / $$ |$$ |  $$ | $$ |    $$$$$$$$ |$$ /  $$ |      $$ |  $$ |$$ /  $$ | $$ |          
  \$$$  /  $$ |$$ |  $$ | $$ |$$\ $$   ____|$$ |  $$ |      $$ |  $$ |$$ |  $$ | $$ |$$\       Contact : ask0v_
   \$  /   $$ |$$ |  $$ | \$$$$  |\$$$$$$$\ \$$$$$$$ |      $$$$$$$  |\$$$$$$  | \$$$$  |      
    \_/    \__|\__|  \__|  \____/  \_______| \_______|      \_______/  \______/   \____/       
                                                                                               

";

            Console.WriteLine(forvisual);
            Console.ResetColor();




            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" ");
            }


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Homme ou Femme ?");
            Console.WriteLine("1: Homme");
            Console.WriteLine("2: Femme");
            Console.WriteLine();
            Console.WriteLine("Parametres : ");
            Console.WriteLine("3: Check Webhook");
            Console.WriteLine("4: Historique de mes recherches");
            Console.WriteLine("5: Auto Buy");
            Console.WriteLine("6: AccesT (Only for debugging)");

            string femmeOrHomme = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" ");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" ");
            }

            Console.ResetColor();




            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" ");
            }



            switch (femmeOrHomme)
            {


                case "1":

                    Console.Clear();


                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Entre le nom de l objet que tu veux snipe ?");
                    string contient_mot = Console.ReadLine();
                    keyword = contient_mot;

                    AddWordHist.createListAdd(contient_mot);

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(" ");
                    }

                    Console.Clear();

                    


                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Entre le timeout en ms : (exemple 1000 = 1sec)");
                    string cont_timeout = Console.ReadLine();
                    int timeout2 = int.Parse(cont_timeout);
                    timeout = timeout2;



                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(" ");
                    }

                    Console.Clear();


                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Entre le prix maximum que tu veux snipe ?");
                    PrixMaximum = Console.ReadLine();

                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Choisi un mode : 1,2,3,4");

                    Console.WriteLine("Mode 1 : Toutes les tailles (S,L,M)");
                    Console.WriteLine("Mode 2 : Taille : S, M");
                    Console.WriteLine("Mode 3 : Taille : S");
                    Console.WriteLine("Mode 4 : Tout les vetements sans tailles");

                    Console.WriteLine("Have error ? contact : ask0v_");



                    string reponseInputuser = Console.ReadLine();



                    Guid randomGuid = Guid.NewGuid();

                    var guid1 = randomGuid.ToString();

                    switch (reponseInputuser)
                    {


                        case "1":

                            Console.Clear();

                            string url = $"https://vinted{await reqRecherche()}/api/v2/catalog/items?page=1&per_page=10&order=newest_first&search_text={trier(contient_mot)}&catalog_ids=&order=newest_first&size_ids=207,208,209";  // Toutes les tailles
                            await getCatalog(url, DiscordWebhook.saveUrl());

                            break;



                        case "2":

                            Console.Clear();

                            string url1 = $"https://vinted{await reqRecherche()}/api/v2/catalog/items?page=1&per_page=10&order=newest_first&search_text={trier(contient_mot)}&catalog_ids=&order=newest_first&size_ids=207,208";   // Taille s, taille m
                            await getCatalog(url1, DiscordWebhook.saveUrl());

                            break;

                        case "3":

                            Console.Clear();


                            string url2 = $"https://vinted{await reqRecherche()}/api/v2/catalog/items?page=1&per_page=10&order=newest_first&search_text={trier(contient_mot)}&catalog_ids=&order=newest_first&size_ids=207";   // Taille s
                            await getCatalog(url2, DiscordWebhook.saveUrl());
                            break;

                        case "4":

                            Console.Clear();

                            string url3 = $"https://vinted{await reqRecherche()}/api/v2/catalog/items?page=1&per_page=10&global_search_session_id={guid1}&search_text={trier(contient_mot)}&catalog_ids=&order=newest_first&size_ids=&brand_ids=&status_ids=&color_ids=&material_ids=";  // Toute recherche sans taille exact
                            await getCatalog(url3, DiscordWebhook.saveUrl());
                            break;

                        default:

                            Console.Clear();
                            Console.WriteLine("Choix invalide. Veuillez choisir un mode entre 1 et 4.");
                            break;
                    }
                    break;

                case "2":

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(" ");
                    }

                    Console.Clear();


                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Entre le nom de l objet que tu veux snipe ?");
                    string contient_mot1 = Console.ReadLine();
                    keyword = contient_mot1;

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(" ");
                    }


                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Entre le prix maximum que tu veux snipe ?");
                    PrixMaximum = Console.ReadLine();


                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Choisi un mode : 1,2,3,4");

                    Console.WriteLine("Mode 1 : Toutes les tailles (S,L,M)");
                    Console.WriteLine("Mode 2 : Taille : S, M");
                    Console.WriteLine("Mode 3 : Taille : S");
                    Console.WriteLine("Mode 4 : Tout les vetements sans tailles");
                    Console.WriteLine("  ");
                    Console.WriteLine("Have error ? contact : ask0v_");



                    string reponseInputuser1 = Console.ReadLine();


                    switch (reponseInputuser1)
                    {


                        case "1":
                            Console.Clear();

                            string url = $"https://vinted{await reqRecherche()}/api/v2/catalog/items?page=1&per_page=10&order=newest_first&search_text={trier(contient_mot1)}&catalog_ids=&order=newest_first&size_ids=3,4,5";  // Toutes les tailles
                            await getCatalog(url, DiscordWebhook.saveUrl());
                            break;


                        case "2":
                            Console.Clear();

                            string url1 = $"https://vinted{await reqRecherche()}/api/v2/catalog/items?page=1&per_page=10&order=newest_first&search_text={trier(contient_mot1)}&catalog_ids=&order=newest_first&size_ids=3,4";   // Taille s, taille m
                            await getCatalog(url1, DiscordWebhook.saveUrl());
                            break;

                        case "3":
                            Console.Clear();

                            string url2 = $"https://vinted{await reqRecherche()}/api/v2/catalog/items?page=1&per_page=10&order=newest_first&search_text={trier(contient_mot1)}&catalog_ids=&order=newest_first&size_ids=3";   // Taille s
                            await getCatalog(url2, DiscordWebhook.saveUrl());
                            break;

                        case "4":
                            Console.Clear();

                            string url3 = $"https://vinted{await reqRecherche()}/api/v2/catalog/items?page=1&per_page=10&order=newest_first&search_text={trier(contient_mot1)}&catalog_ids=&order=newest_first";  // Toute recherche sans taille exact
                            await getCatalog(url3, DiscordWebhook.saveUrl());
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Choix invalide. Veuillez choisir un mode entre 1 et 4.");
                            break;
                    }
                    break;

                case "3":
                    Console.Clear();
                    await checkWebhook(DiscordWebhook.saveUrl());
                    break;

                case "4":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(AddWordHist.lookHisto());
                    Console.ResetColor();
                    Console.ReadLine();
                    break;

                case "5":
                    Console.Clear();
                    
                    string accestoken = await AccesToken.getAccesToken();
                    string result = await Autobuy.login(accestoken);
                    break;

                case "6":
                    Console.Clear();
                    string accestoken1 = await AccesToken.getAccesToken();
                    string refreshtoken = await AccesToken.getRefreshToken();
                    Console.WriteLine($"{accestoken1}");

                    Console.WriteLine($"{refreshtoken}");
                    break;




                default:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Choisi un genre homme ou femme");
                    Console.ResetColor();
                    break;

            }
        }

        else
        {
            Console.Clear();

            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Tu peux pas partagé le logiciel merci de l'acheté.");
            Console.ReadLine();
            Console.ResetColor();
        }





        



    }

    static string trier(string keyword)
    {
        return keyword.Replace(" ", "+");
        
    }

    static async Task getCatalog(string url, string webhook)
    {

        

        try
        {

            

            int articlesTrouves = 0;
            int erreurs = 0;
            int articlesVerifies = 0;

            while (2 > 1)
            {


                string accestoken = await AccesToken.getAccesToken();

                string refreshtoken = await AccesToken.getRefreshToken();

                await Task.Delay(timeout);








                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/138.0.0.0 Safari/537.36");
                    client.DefaultRequestHeaders.Add("Cookie", $"access_token_web={accestoken}; refresh_token_web={refreshtoken}");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
                    client.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*,image/webp");
                    client.DefaultRequestHeaders.Add("Accept-Language", "fr");



                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        var vintedCatalog = JsonSerializer.Deserialize<VintedCatalog>(jsonResponse);

                        if (vintedCatalog?.items != null)
                        {
                            foreach (var item in vintedCatalog.items)
                            {
                                


                                string[] splitNumber = item.price.amount.Split(".");
                                 

                                string partieOfficielle = splitNumber[0];

                                int price = int.Parse(partieOfficielle);


                                string prixMaximumString = Program.PrixMaximum;

                                int maxPrice = int.Parse(prixMaximumString);


                                long itemId = item.id;           //ici


                                var slll = await Doublons.checkDouble(itemId);



                                
                                if (slll)
                                {
                                    articlesTrouves++;
                                    UpdatePanel(articlesTrouves, erreurs, articlesVerifies);


                                    if (maxPrice > price)
                                    {
                                        try
                                        {
                                            using (HttpClient client2 = new HttpClient())
                                            {
                                                var content = new
                                                {
                                                    username = "Vinted Bot [Askov]",
                                                    embeds = new[]
                                                    {
                                            new {
                                                title = "Vinted Bot",
                                                image = (item.photo != null) ? new { url = item.photo.url } : null,
                                                fields = new[]
                                                {
                                                    new { name = "", value = ("-----------------------------"), inline = false },
                                                    new { name = "Titre", value = ($"{item.title}"), inline = true },
                                                    new { name = "Prix", value = ($"{item.price.amount} {item.price.currency_code}"), inline = true },
                                                    new { name = "Lien", value = ($"{item.url}"), inline = true },
                                                    new { name = "Date", value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), inline = true },
                                                    new { name = "Contact", value = ("Discord : ask0v_"), inline = false },
                                                    new { name = "", value = ("-----------------------------"), inline = false },


                                                }
                                            }
                                            }
                                                };

                                                articlesVerifies++;
                                                UpdatePanel(articlesTrouves, erreurs, articlesVerifies);

                                                string json = JsonSerializer.Serialize(content);

                                                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                                                try
                                                {
                                                    var response1 = await client.PostAsync(webhook, httpContent);
                                                    if (!response.IsSuccessStatusCode)
                                                    {
                                                        Console.WriteLine("Erreur en envoyant le webhook Discord.");


                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine("Rentre un webhook valide ou contact ask0v_ sur discord");
                                                    Panel.IncrementErrors();

                                                }

                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine($"Error: {e.Message} Contact : ask0v_ MAUVAIS WEBHOOK");
                                            erreurs++;
                                            UpdatePanel(articlesTrouves, erreurs, articlesVerifies);


                                        }






                                    }
                                }
                                



                                
                            }
                        }
                        else
                        {
                            Console.WriteLine("Aucun article trouver ou format JSON incorrect.");
                            erreurs++;
                            UpdatePanel(articlesTrouves, erreurs, articlesVerifies);


                        }




                    }
                    else
                    {
                        Console.WriteLine("Probleme dans le parse du json lors de la requete getCatalog contact ask0v_ : " + response.StatusCode);
                        erreurs++;
                        UpdatePanel(articlesTrouves, erreurs, articlesVerifies);


                    }


                }
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message} Contact : ask0v_");
            Panel.IncrementErrors();


        }

    }


    static async Task<string> checkWebhook(string webhook)
    {
        try
        {
            using (HttpClient client2 = new HttpClient())
            {
                var content = new
                {
                    username = "Vinted Bot [Askov] TEST WEBHOOK",
                    embeds = new[]
                    {
                                            new {
                                                title = "Vinted Bot ON OR OFF",
                                                fields = new[]
                                                {
                                                    new { name = "", value = ("-----------------------------"), inline = false },
                                                    new { name = "Test", value = ("Test réussi ton webhook est valide"), inline = false },
                                                    new { name = "Date", value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), inline = false },
                                                    new { name = "Contact", value = ("Discord : ask0v_"), inline = false }
                                                }
                                            }
                     }
                    
                };

                string json = JsonSerializer.Serialize(content);
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client2.PostAsync(webhook, httpContent);

                response.EnsureSuccessStatusCode();

                return "Webhook Valide";

            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message} Contact : ask0v_ partie webhook FAITES PAS ATTENTION EN TANT QUE CLIENT");

            return "Mauvais webhook";
        }
    }

    static void UpdatePanel(int articlesTrouves, int erreurs, int articlesVerifies)
    {
        
        Console.Clear();


        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.ForegroundColor = ConsoleColor.Blue;

        
        Console.WriteLine($@"
                            ════════════════════════════════════════════════════
                                            V I N T E D   A S K O V   B O T
                            ══════════════════╦═════════════════════════════════
                             Articles trouvés ║ {articlesTrouves,10}
                            ──────────────────╬─────────────────────────────────
                             Erreurs          ║ {erreurs,10}
                            ──────────────────╬─────────────────────────────────
                             Articles vérifiés║ {articlesVerifies,10}
                            ══════════════════╩═════════════════════════════════


                                              Settings :
                                                
                                    - Nom De Domaine vinted : {nomdedom}

                                    - Article : {keyword}

                                    - Prix Max : {PrixMaximum}

                                    - Hwid : {hwidI}






");

        Console.ResetColor();

        



    }

    static async Task<string> reqRecherche()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Entre le nom de domaine vinted dans le quel tu veux faire tes recherches (exemple: .fr) : ");
        string ndd = Console.ReadLine();
        Console.ResetColor();

        nomdedom = ndd;

        return ndd;
    }




}   
