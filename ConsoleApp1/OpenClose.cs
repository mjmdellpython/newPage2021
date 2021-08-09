using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OpenClose
    {
    }




}

//public enum BaseType
//{
//    Binary = 2, Octal = 8, None = 0
//}

////public class Logger
////{
////    public void log(string message)
////    {
////        Console.WriteLine(message);
////    }
////}

////public class Reader
////{
////    public int readInteger()
////    {
////        return int.Parse(Console.ReadLine());
////    }
////}

//class logger//OUT PUT
//{
//    public void log(string m)
//    {
//        Console.WriteLine(m);
//    }
//}
//class reader//INPUT
//{
//    public int readInteger()
//    {
//        return int.Parse(Console.ReadLine());
//    }
//}

//class SolidSample
//{
//    public int DecimalNumber { get; set; }
//    //public Logger logger { get; set; } = new Logger();
//    //public Reader reader { get; set; } = new Reader();

//    public logger logger { get; set; } = new logger();
//    public reader reader { get; set; } = new reader();

//    public void Convert()
//    {
//        //Console.WriteLine("Program is start");
//        logger.log("Program is start");//*************************
//                                       //Console.WriteLine("Enter the number to convert...");
//        logger.log("Enter the number to convert...");//*************************
//                                                     //DecimalNumber = int.Parse(Console.ReadLine());
//        DecimalNumber = reader.readInteger();//***************************
//                                             //Console.WriteLine("Enter the Base type to convert (Ex: 2,8).");
//        logger.log("Enter the Base type to convert (Ex: 2,8).");
//        //var baseType = (BaseType)int.Parse(Console.ReadLine());
//        var baseType = (BaseType)reader.readInteger();
//        string resulting = string.Empty;
//        switch (baseType)
//        {
//            case BaseType.Binary:
//                resulting = System.Convert.ToString(DecimalNumber, 2);
//                break;
//            case BaseType.Octal:
//                resulting = System.Convert.ToString(DecimalNumber, 8);
//                break;
//            default:
//                resulting = "No base found!";
//                break;
//        }

//        //Console.WriteLine($"The result is :{resulting}");
//        logger.log($"The result is :{resulting}");
//        //Console.WriteLine("Program is ending...");
//        logger.log("Program is ending...");

//    }
//}
