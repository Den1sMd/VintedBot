using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vinted_UK_Bot
{
    internal class AddWordHist
    {

        private static readonly string filePath = "historique.txt";


        public static void createListAdd(string word)
        {
            if (!String.IsNullOrEmpty(word))
            {
                File.AppendAllLines(filePath, new[] {word});
            }
        }

        public static string lookHisto()
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            return "Vous n'avez pas fais de recherches.";
        }
    }
}
