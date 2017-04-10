using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Hat
{
    class Christmas_Hat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', 2 * n - 1) + "/|\\" + new string('.', 2 * n - 1));
            Console.WriteLine(new string('.', 2 * n - 1) + "\\|/" + new string('.', 2 * n - 1));
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine(new string('.', 2 * n - i - 1) + "*" + new string('-', i) + "*" + new string('-', i) +
                    "*" + new string('.', 2 * n - i - 1));
            }
            Console.WriteLine(new string('*', 4 * n + 1));
            for (int j = 0; j < 2 * n + 1; j++)
            {
                if (j < 2 * n) Console.Write(new string('*', 1) + new string('.', 1));
                else Console.Write(new string('*', 1));
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}