using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11_практика_задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Ведите фамилию: ");
            string name2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"имя: {name1}, фамилия: {name2}");
            Console.ReadKey();
        }
    }
}
