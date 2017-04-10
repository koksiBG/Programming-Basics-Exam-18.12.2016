using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            double top = 0;
            double Between1 = 0;
            double Between2 = 0;
            double Fail = 0;
            double Average = 0;
            for (int i = 0; i < students; i++)
            {
                double Grade = double.Parse(Console.ReadLine());
                Average += Grade;
                if (Grade >= 2.00 && Grade <= 2.99) count1++;
                else if (Grade >= 3.00 && Grade <= 3.99) count2++;
                else if (Grade >= 4.00 && Grade <= 4.99) count3++;
                else if (Grade >= 5.00 && Grade <= 6.00) count4++;
            }
            top = (double)count4 / students * 100;
            Between1 = (double)count3 / students * 100;
            Between2 = (double)count2 / students * 100;
            Fail = (double)count1 / students * 100;
            Average = Average / students;
            Console.WriteLine($"Top students: {top:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {Between1:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {Between2:f2}%");
            Console.WriteLine($"Fail: {Fail:f2}%");
            Console.WriteLine($"Average: {Average:f2}");
        }
    }
}