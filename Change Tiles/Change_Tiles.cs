using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Tiles
{
    class Change_Tiles
    {
        static void Main(string[] args)
        {
            double CollectedMoney = double.Parse(Console.ReadLine());
            double WidthArea = double.Parse(Console.ReadLine());
            double LengthArea = double.Parse(Console.ReadLine());
            double SideTriangle = double.Parse(Console.ReadLine());
            double HightTriangle = double.Parse(Console.ReadLine());
            double PriceTiles = double.Parse(Console.ReadLine());
            double SumMaster = double.Parse(Console.ReadLine());
            double AreaBelow = WidthArea * LengthArea;
            double AreaTriangle = SideTriangle * HightTriangle / 2;
            int NeededTiles = (int)(Math.Ceiling(AreaBelow / AreaTriangle) + 5);
            double SumPriceTiles = NeededTiles * PriceTiles;
            double TotalPrice = SumPriceTiles + SumMaster;
            if  (TotalPrice <= CollectedMoney)
            {
                Console.WriteLine($"{(CollectedMoney - TotalPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {(TotalPrice - CollectedMoney):f2} lv more.");
            }
        }
    }
}