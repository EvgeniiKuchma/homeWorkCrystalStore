using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkCrystalStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int costOneCrystal = 11;
            int userNumberGold;
            int userNumberCrystal;           

            Console.Write("Hello traveler how mach gold you have?: ");
            userNumberGold = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Ok, do you have {userNumberGold} gold, " +
                $"remeber price per crystal {costOneCrystal}," +
                $" now how mach crytal do you want by?: ");
            userNumberCrystal = Convert.ToInt32(Console.ReadLine());

            userNumberGold = userNumberGold - userNumberCrystal * costOneCrystal;

            Console.WriteLine($"Do you have {userNumberCrystal} crystal and you gold risedue {userNumberGold}");
        }
    }
}
