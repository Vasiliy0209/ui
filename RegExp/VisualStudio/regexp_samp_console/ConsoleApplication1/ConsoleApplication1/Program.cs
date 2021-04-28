using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Строка для парсинга
            string input_text = @"размер_шрифта=10;
                                  line_height=5;
                                  начертание=bold;
                                  value=Test this program;";

            string regexp = @"([A-Za-zА-Яа-я_]+)\s*=\s*([^=^;]+);";
            
            MatchCollection matches = Regex.Matches(input_text, regexp);
            foreach(Match m in matches)
            {
                Console.WriteLine("Переменная:"+m.Groups[1].Value
                    +" Значение:"+m.Groups[2].Value);
            }

            Console.ReadKey();
        }
    }
}
