using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа через запятую");
            var a = Console.ReadLine();
            var arr = a.Split(',');
            foreach (var i in arr)
            {
                int result = 0;
                if (!int.TryParse(i, out result))
                {
                    Console.WriteLine("Ошибка");
                }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
