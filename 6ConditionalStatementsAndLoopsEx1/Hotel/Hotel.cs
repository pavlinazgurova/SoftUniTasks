using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            var priceForStudio = 0.00;
            var priceForDouble = 0.00;
            var priceForSuite = 0.00;
            var totalPriceStudio = 0.00;
            var totalPriceDouble = 0.00;
            var totalPriceSuite = 0.00;

            switch (month)
            {
                case "May":
                case "October":
                    priceForStudio = 50.00;
                    priceForDouble = 65.00;
                    priceForSuite = 75.00;
                    break;
                case "June":
                case "September":
                    priceForStudio = 60.00;
                    priceForDouble = 72.00;
                    priceForSuite = 82.00;
                    break;
                case "July":
                case "August":
                case "December":
                    priceForStudio = 68.00;
                    priceForDouble = 77.00;
                    priceForSuite = 89.00;
                    break;
                default:
                    break;
            }

            if ((month == "May" || month == "October") && nightsCount > 7)
            {
                priceForStudio *= 0.95;
            }
            if ((month == "June" || month == "September") && nightsCount > 14)
            {
                priceForDouble *= 0.9;
            }
            if ((month == "July" || month == "August" || month == "December") && nightsCount > 14)
            {
                priceForSuite *= 0.85;
            }

            totalPriceStudio = priceForStudio * nightsCount;
            totalPriceDouble = priceForDouble * nightsCount;
            totalPriceSuite = priceForSuite * nightsCount;

            if ((month == "September" || month == "October") && nightsCount > 7)
            {
                totalPriceStudio -= priceForStudio;
            }

            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
            Console.WriteLine($"Double: {totalPriceDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalPriceSuite:f2} lv.");
            

        }
    }
}

//switch (month)
//{
//    case "May":
//    case "October":
//        if (nightsCount >= 7)
//        {
//            priceForStudio = (50 * (double)nightsCount) - ((50 * (double)nightsCount) * 0.05);
//            priceForDouble = 65 * (double)nightsCount;
//            priceForSuite = 75 * (double)nightsCount;
//        }
//        else
//        {
//            priceForStudio = 50 * (double)nightsCount;
//            priceForDouble = 65 * (double)nightsCount;
//            priceForSuite = 75 * (double)nightsCount;
//        }

//        break;
//    case "June":
//    case "September":
//        if (nightsCount >= 7)
//        {
//            priceForStudio = (60 * (double)nightsCount) - 60;
//            priceForDouble = 72 * (double)nightsCount;
//            priceForSuite = 82 * (double)nightsCount;
//        }
//        else if (nightsCount >= 14)
//        {
//            priceForStudio = (60 * (double)nightsCount) - 60;
//            priceForDouble = (72 * (double)nightsCount) - ((72 * (double)nightsCount) * 0.10);                        
//            priceForSuite = 82 * (double)nightsCount;
//        }
//        else
//        {
//            priceForStudio = 60 * (double)nightsCount;
//            priceForDouble = 72 * (double)nightsCount;
//            priceForSuite = 82 * (double)nightsCount;
//        }

//        break;
//    case "July":
//    case "August":
//    case "December":
//        if (nightsCount >= 14)
//        {
//            priceForStudio = 68 * (double)nightsCount;
//            priceForDouble = 77 * (double)nightsCount;
//            priceForSuite = (89 * (double)nightsCount) - ((89 * (double)nightsCount) * 0.15);
//        }
//        else
//        {
//            priceForStudio = 68 * (double)nightsCount;
//            priceForDouble = 77 * (double)nightsCount;
//            priceForSuite = 89 * (double)nightsCount;
//        }
//        break;
//    default:
//        break;
//}
//Console.WriteLine($"Studio: {priceForStudio:f2} lv.");
//Console.WriteLine($"Double: {priceForDouble:f2} lv.");
//Console.WriteLine($"Suite: {priceForSuite:f2} lv.");
