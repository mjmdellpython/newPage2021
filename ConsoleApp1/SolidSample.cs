using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    public enum BaseType
    {
        Binary = 2, Octal = 8, Hexadecimal = 0
    }

    class logger//OUT PUT
    {
        public void log(string m)
        {
            Console.WriteLine(m);
        }
    }
    class reader//INPUT
    {
        public int readInteger()
        {
            return int.Parse(Console.ReadLine());
        }
    }


    public abstract class Converter
    {
        public int DecimalNumber { get; set; }
        public Converter(int decimalNumber)
        {
            DecimalNumber = decimalNumber;
        }
        public abstract string IConvert();
    }

    public class BinaryConverter:Converter
    {
        public BinaryConverter(int decimalNumber):base(decimalNumber)
        {

        }

        public override string IConvert()
        {
            return $"The result is: {System.Convert.ToString(DecimalNumber,2)}";
        }

    }

    public class OctalConverter : Converter
    {
        public OctalConverter(int decimalNumber) : base(decimalNumber)
        {

        }

        public override string IConvert()
        {
            return $"The result is: {System.Convert.ToString(DecimalNumber,8)}";
        }

    }

    public class HixadecimalConverter : Converter
    {
        public HixadecimalConverter(int decimalNumber) : base(decimalNumber)
        {

        }

        public override string IConvert()
        {
            return $"The result is: {System.Convert.ToString("X")}";
        }

    }



    class SolidSample
    {
        public int DecimalNumber { get; set; }


        public logger logger { get; set; } = new logger();
        public reader reader { get; set; } = new reader();

        public void Convert()
        {

            logger.log("Program is start");//*************************

            logger.log("Enter the number to convert...");//*************************

            DecimalNumber = reader.readInteger();//***************************

            logger.log("Enter the Base type to convert (Ex: 2,8).");

            var baseType = (BaseType)reader.readInteger();
            string resulting = string.Empty;
            switch (baseType)
            {
                case BaseType.Binary:
                    //resulting = System.Convert.ToString(DecimalNumber,2);
                    var BinaryConverter = new BinaryConverter(DecimalNumber);
                    resulting = BinaryConverter.IConvert();
                    break;
                case BaseType.Octal:
                    //resulting = System.Convert.ToString(DecimalNumber, 8);
                    var ObticalConverter = new OctalConverter(DecimalNumber);
                    resulting = ObticalConverter.IConvert();
                    break;
                case BaseType.Hexadecimal:
                    //resulting = System.Convert.ToString(DecimalNumber, 8);
                    var HexidecimalConverter = new HixadecimalConverter(DecimalNumber);
                    resulting = HexidecimalConverter.IConvert();
                    break;
                default:
                    resulting = "No base found!";
                    break;
            }


            logger.log($"The result is :{resulting}");

            logger.log("Program is ending...");

        }
    }
}
