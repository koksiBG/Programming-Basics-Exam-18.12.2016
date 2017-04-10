using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Distance
    {
        static void Main(string[] args)
        {
            int BeginSpeed = int.Parse(Console.ReadLine());
            int FirstTime = int.Parse(Console.ReadLine());
            int SecondTime = int.Parse(Console.ReadLine());
            int ThirdTime = int.Parse(Console.ReadLine());
            double FirstHours = (double)FirstTime / 60;
            double SecondHours = (double)SecondTime / 60;
            double ThirdTHours = (double)ThirdTime / 60;
            double FirstDistance = BeginSpeed * FirstHours;
            double SecondDistance = BeginSpeed * 1.1 * SecondHours;
            double ThirdDistance = BeginSpeed * 1.1 * .95 * ThirdTHours;
            double SumDistance = FirstDistance + SecondDistance + ThirdDistance;
            Console.WriteLine($"{SumDistance:f2}");
        }
    }
}