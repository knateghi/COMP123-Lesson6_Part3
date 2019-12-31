using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_Part3
{
    //This is the driver class for the project
    class Program
    {
        static void Main(string[] args)
        {
            Card myCard = new Card("Ace", "Hearts");
            myCard.Show();

            WaiForAnyKey();
        }

        private static void WaiForAnyKey()
        {
            Console.WriteLine("\n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Please hit any key to exit...");
            Console.ReadKey();
        }
    }
}
