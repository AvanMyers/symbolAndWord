using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbolAndWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            char symbol;
            string characterString = "";

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите символ: ");
            symbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < name.Length + 2; i++)
            {
                characterString += symbol;
            }
            Console.WriteLine(characterString);
            Console.WriteLine($"{symbol}{name}{symbol}");
            Console.WriteLine(characterString);

            Console.ReadKey();
        }
    }
}
