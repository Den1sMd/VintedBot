using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinted_UK_Bot
{
    internal class Doublons
    {


        private static readonly string filePath = "double.txt";


        public static async Task<bool> checkDouble(long number)
        {



            var numStr = number.ToString();


            if (!File.Exists(filePath))
            {
                await File.WriteAllTextAsync(filePath, numStr + Environment.NewLine);
                return true;
            }

            


            if (File.Exists(filePath))
            {
                var num2 = await File.ReadAllLinesAsync(filePath);

                if (num2.Contains(numStr))
                {
                    return false;
                }
                else
                {
                    await File.AppendAllLinesAsync(filePath, new[] { numStr });
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
