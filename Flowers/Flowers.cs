using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            int Chrysanthemums = int.Parse(Console.ReadLine());
            int Roses = int.Parse(Console.ReadLine());
            int Tulips = int.Parse(Console.ReadLine());
            string Season = Console.ReadLine();
            char Holiday = char.Parse(Console.ReadLine());
            int Flowers = Chrysanthemums + Roses + Tulips;
            double PriceChrys = 0;
            double PriceRoses = 0;
            double PriceTulips = 0;
            double DiscountOne = 0;
            double DiscountTwoo = 0;
            double DiscountTree = 0;
            double TotalChrys = 0;
            double TotalRoses = 0;
            double TotalTulips = 0;
            double PriceFlowers = 0;
            double TotalFlowers = 0;
            if (Season == "Spring" || Season == "Summer")
            {
                PriceChrys = 2.00;
                PriceRoses = 4.10;
                PriceTulips = 2.50;
            }
            else if (Season == "Autumn" || Season == "Winter")
            {
                PriceChrys = 3.75;
                PriceRoses = 4.50;
                PriceTulips = 4.15;
            }
            TotalChrys = Chrysanthemums * PriceChrys;
            TotalRoses = Roses * PriceRoses;
            TotalTulips = Tulips * PriceTulips;
            PriceFlowers = TotalChrys + TotalRoses + TotalTulips;
            if (Holiday == 'Y')
                PriceFlowers = PriceFlowers * 1.15;
            if (Tulips > 7 && Season == "Spring")
                DiscountOne = 0.05 * PriceFlowers;
            PriceFlowers = PriceFlowers - DiscountOne;
            if (Roses >= 10 && Season == "Winter")
                DiscountTwoo = 0.10 * PriceFlowers;
            PriceFlowers = PriceFlowers - DiscountTwoo;
            if (Flowers > 20)
                DiscountTree = 0.2 * PriceFlowers;
            PriceFlowers = PriceFlowers - DiscountTree;
            TotalFlowers = PriceFlowers + 2;
            Console.WriteLine($"{(TotalFlowers):f2}");
        }
    }
}