using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba3.Manager
{
    public interface INumberSystem
    {
        string Addition(string A, string B);
        string Substraction(string A, string B);
        string Multiplication(string A, string B);
        string Division(string A, string B);
        string Power(string A, string B);
        string From10To2(long DecimalNumber, int Radix);
        long From2To10(string Number, int Radix);
        string From10To11(long DecimalNumber, int Radix);
        long From11To10(string Number, int Radix);
        int ArrayLaba1(int[] arr1);
    }
}
