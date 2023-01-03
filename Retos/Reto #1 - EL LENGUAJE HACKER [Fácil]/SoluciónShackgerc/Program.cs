using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoluciónShackgerc
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> leet = new Dictionary<string, string>()
            {
                ["A"] = "4",
                ["B"] = "5",
                ["C"] = "[",
                ["D"] = ")",
                ["E"] = "3",
                ["F"] = "|=",
                ["G"] = "&",
                ["H"] = "#",
                ["I"] = "1",
                ["J"] = ",_|",
                ["K"] = ">|",
                ["L"] = "1",
                ["M"] = @"/\/\",
                ["N"] = @"^/",
                ["Ñ"] = "~",
                ["O"] = "0",
                ["P"] = "|*",
                ["Q"] = "(_,)",
                ["R"] = "I2",
                ["S"] = "5",
                ["T"] = "7",
                ["U"] = "(_)",
                ["V"] = @"\/",
                ["W"] = @"\/\/",
                ["X"] = "><",
                ["Y"] = "j",
                ["Z"] = "2",

                ["1"] = "L",
                ["2"] = "R",
                ["3"] = "E",
                ["4"] = "A",
                ["5"] = "S",
                ["6"] = "b",
                ["7"] = "T",
                ["8"] = "B",
                ["9"] = "g",
                ["0"] = "0"
            };

            string ToLeetCode(string AlphanumericExpression)
            {
                string result = "";

                foreach (char digit in AlphanumericExpression)
                {
                    if (digit == ' ')
                        result += ' ';
                    else
                        try
                        {
                            result += leet[digit.ToString().ToUpper()];
                        }
                        catch (Exception)
                        {
                            result += digit;
                        }
                }
                return result;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ingrese la oración a texto a transformar (ctrl + c para cerrar): ");
                string text = Console.ReadLine();
                string translatedText = ToLeetCode(text);
                
                if(translatedText.Length > 0)
                {
                    Console.WriteLine("Resultado: " + " " + translatedText);
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }
            }
 
        }
    }
}
