using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vinted_UK_Bot
{
    internal class Panel
    {

        


        private static int articlesTrouves = 0;
        private static int errors = 0;
        private static int articlesCheck = 0;

        public static async Task<string> forpanel()
        {
            

            string panel1 = @$"
        ╔════════════════════════════╗
        ║    🏛  Vinted Askov Bot 🏛   ║
╔═══════╩════════════════════════════╩═══════╗
║ Articles trouvés ⚡ : {articlesTrouves,-6}              ║
║ Erreurs        ⚠️ : {errors,-6}              ║
║ Articles vérifiés 🔍: {articlesCheck,-6}              ║
╚═══════════════════════════════════════════╝
";

            Console.WriteLine(panel1);

            return panel1;
        }


        public static int IncrementArticlesTrouves()
        {
            articlesTrouves++;
            return articlesTrouves;


        }


        public static int IncrementErrors()
        {
            errors++;
            return errors;
        }

        public static int IncrementArticlesCheck()
        {
            articlesCheck++;
            return articlesCheck;
        }
    }
}
