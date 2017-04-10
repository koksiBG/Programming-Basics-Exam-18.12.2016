using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Combinations
{
    class Letters_Combinations
    {
        static void Main(string[] args)
        {
            char Begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char stop = char.Parse(Console.ReadLine());
            int count = 0;
            for (char i = Begin; i <= end; i++)
            {
                for (char j = Begin; j <= end; j++)
                {
                    for (char k = Begin; k <= end; k++)
                    {
                        if (i != stop && j != stop && k != stop)
                        { 
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");
                            count++;
                        }
                    }
                }
                if (i == end) Console.Write(count);
            }
        }
    }
}