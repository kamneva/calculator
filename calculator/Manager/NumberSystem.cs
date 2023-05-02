using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba3.Manager
{
    public class NumberSystem : INumberSystem
    {
        public string Addition(string A, string B)
        {
            return Convert.ToString(Convert.ToDecimal(A) + Convert.ToDecimal(B));
        }
        public string Substraction(string A, string B)
        {
            return Convert.ToString(Convert.ToDecimal(A) - Convert.ToDecimal(B));
        }
        public string Multiplication(string A, string B)
        {
            return Convert.ToString(Convert.ToDecimal(A) * Convert.ToDecimal(B));
        }
        public string Division(string A, string B)
        {
            return Convert.ToString(Convert.ToDecimal(A) / Convert.ToDecimal(B));
        }
        public string Power(string A, string B)
        {
            return Convert.ToString(Math.Pow(Convert.ToDouble(A), Convert.ToDouble(B)));
        }
       
        public int ArrayLaba1(int [] arr1)
        {
            int k = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 5 == 0)
                    k++;
            }
            return k;
            
        }
        public string From10To2(long DecimalNumber, int Radix)
        {
            const int BitsInLong = 64;
            const string Digits = "01";
            if (DecimalNumber == 0)
                return "0";
            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(DecimalNumber);
            char[] charArray = new char[BitsInLong];
            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % Radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / Radix;
            }
            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (DecimalNumber < 0)
            {
                result = "-" + result;
            }
            return result;
        }

        public long From2To10(string Number, int Radix)
        {
            const string Digits = "01";
            if (String.IsNullOrEmpty(Number))
                return 0;
            Number = Number.ToUpperInvariant();
            long result = 0;
            long multiplier = 1;
            for (int i = Number.Length - 1; i >= 0; i--)
            {
                char c = Number[i];
                if (i == 0 && c == '-')
                {
                    result = -result;
                    break;
                }
                int digit = Digits.IndexOf(c);
                result += digit * multiplier;
                multiplier *= Radix;
            }
            return result;
        }

        public string From10To11(long DecimalNumber, int Radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789A";
            if (DecimalNumber == 0)
                return "0";
            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(DecimalNumber);
            char[] charArray = new char[BitsInLong];
            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % Radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / Radix;
            }
            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (DecimalNumber < 0)
            {
                result = "-" + result;
            }
            return result;
        }

        public long From11To10(string Number, int Radix)
        {
            const string Digits = "0123456789A";
            if (String.IsNullOrEmpty(Number))
                return 0;
            Number = Number.ToUpperInvariant();
            long result = 0;
            long multiplier = 1;
            for (int i = Number.Length - 1; i >= 0; i--)
            {
                char c = Number[i];
                if (i == 0 && c == '-')
                {
                    result = -result;
                    break;
                }
                int digit = Digits.IndexOf(c);
                result += digit * multiplier;
                multiplier *= Radix;
            }
            return result;
        }
    }
}
