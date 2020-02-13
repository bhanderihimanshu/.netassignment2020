using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class Class1
    {
        public static string decimal2binary(string decimalStr)
        {
            string binaryStr="";
            int d = int.Parse(decimalStr);
            int b;
            while (d >= 2)
            {
                b = d % 2;
                binaryStr += b;
                d /= 2;
            }
            binaryStr += d;
            char[] charBinary = binaryStr.ToCharArray();
            Array.Reverse(charBinary);
            return new string(charBinary);
        }
        public static string binary2decimal(string binaryStr)
        {
            double sum=0;
            for(int i = 0; i < binaryStr.Length; i++)
            {
                sum +=(  (double)char.GetNumericValue(binaryStr[i]) * Math.Pow(2, binaryStr.Length - i - 1) );
            }
            return sum.ToString();
        }
        public static string decimal2hex(string decimalStr)
        {
            string hexStr = "";
            int d = int.Parse(decimalStr);
            int b;
            while (d >= 16)
            {
                b = d % 16;
                hexStr += getHexChar(b);
                d /= 16;
            }
            hexStr += getHexChar(d);
            char[] charHex = hexStr.ToCharArray();
            Array.Reverse(charHex);
            return new string(charHex);
        }
        public static string decimal2octal(string decimalStr)
        {
            string octalStr = "";
            int d = int.Parse(decimalStr);
            int b;
            while (d >= 8)
            {
                b = d % 8;
                octalStr += b;
                d /= 8;
            }
            octalStr += d;
            char[] charOctal = octalStr.ToCharArray();
            Array.Reverse(charOctal);
            return new string(charOctal);
        }
        public static string getHexChar(int h)
        {
            if (h < 10 && h >= 0)
                return h.ToString();
            switch (h)
            {
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
            }
            return "";
        }
    }
}
