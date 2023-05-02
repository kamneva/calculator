using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Laba3.Manager;

namespace Laba3.Controllers
{
    public class CalculatorController : Controller
    {
        INumberSystem _NS;
        public CalculatorController(INumberSystem NS)
        {
            _NS = NS;
        }
        public ViewResult Main()
        {
            return View();
        }
        public ActionResult Calculate(string InputStr)
        {
            try
            {
                string Answer = "Ошибка";
                var UsingStr = InputStr.Replace(" ", string.Empty);
                string[] Signs = new string[] { "+", "-", "*", "/", "^" };
                string[] Numbers = UsingStr.Split(Signs, StringSplitOptions.None);
                string SingsStr = UsingStr.Replace(Numbers[0], string.Empty);
                SingsStr = SingsStr.Replace(Numbers[1], string.Empty);
                string A = Numbers[0];
                string B = Numbers[1];
                if (SingsStr == "+")
                {
                    Answer = Convert.ToString(_NS.Addition(A, B));
                }
                if (SingsStr == "-")
                {
                    Answer = Convert.ToString(_NS.Substraction(A, B));
                }
                if (SingsStr == "*")
                {
                    Answer = Convert.ToString(_NS.Multiplication(A, B));
                }
                if (SingsStr == "/")
                {
                    Answer = Convert.ToString(_NS.Division(A, B));
                }
                if (SingsStr == "^")
                {
                    Answer = Convert.ToString(_NS.Power(A, B));
                }
                try
                {
                    return View("Calculator", Answer);
                }
                catch
                {
                    return RedirectToAction(nameof(Calculator));
                }
            }
            catch { return RedirectToAction(nameof(Calculator)); }
 
        }
        public ViewResult Calculator()
        {
            return View();
        }
        public ActionResult Laba1Calc(string InputStr)
        {
            try
            {
                string[] UsingStr = InputStr.Split(" ", StringSplitOptions.None);
                int[] IntStr = new int[UsingStr.GetLength(0)];
                string Answer;
                for (int i = 0; i < UsingStr.Length; i++)
                {
                    IntStr[i] = Convert.ToInt32(UsingStr[i]);
                }
                Answer = Convert.ToString(_NS.ArrayLaba1(IntStr));
                try
                {
                    return View("Laba1", Answer);
                }
                catch
                {
                    return RedirectToAction(nameof(Laba1));
                }
            }
            catch{ return RedirectToAction(nameof(Laba1)); }
        }
        public ViewResult Laba1()
        {
            return View();
        }
        public ActionResult Calculate2(string InputStr)
        {
            try
            {
                long Answer = 0;
                var UsingStr = InputStr.Replace(" ", string.Empty);
                string[] Signs = new string[] { "+", "-", "*", "/", "^"};
                string[] Numbers = UsingStr.Split(Signs, StringSplitOptions.None);
                if (Numbers.Length < 2)
                {
                    try
                    {
                        return View("Calculator2", Answer);
                    }
                    catch
                    {
                        return RedirectToAction(nameof(Calculator2));
                    }
                }
                else
                {
                    string SingsStr = UsingStr.Replace(Numbers[0], string.Empty);
                    SingsStr = SingsStr.Replace(Numbers[1], string.Empty);
                    long A = _NS.From2To10(Numbers[0], 2);
                    long B = _NS.From2To10(Numbers[1], 2);
                    if (SingsStr == "+")
                    {
                        Answer = Convert.ToInt64(_NS.Addition(Convert.ToString(A), Convert.ToString(B)));
                    }
                    if (SingsStr == "-")
                    {
                        Answer = Convert.ToInt64(_NS.Substraction(Convert.ToString(A), Convert.ToString(B)));
                    }
                    if (SingsStr == "*")
                    {
                        Answer = Convert.ToInt64(_NS.Multiplication(Convert.ToString(A), Convert.ToString(B)));
                    }
                    if (SingsStr == "/")
                    {
                        Answer = Convert.ToInt64(_NS.Division(Convert.ToString(A), Convert.ToString(B)));
                    }
                    if (SingsStr == "^")
                    {
                        Answer = Convert.ToInt64(_NS.Power(Convert.ToString(A), Convert.ToString(B)));
                    }
                    try
                    {
                        return View("Calculator2", _NS.From10To2(Answer, 2));
                    }
                    catch
                    {
                        return RedirectToAction(nameof(Calculator2));
                    }
                }
            }
            catch { return RedirectToAction(nameof(Calculator2)); }
        }
        public ViewResult Calculator2()
        {
            return View();
        }
        public ActionResult Calculate3(string InputStr)
        {
            try
            {
                long Answer = 0;
                var UsingStr = InputStr.Replace(" ", string.Empty);
                string[] Signs = new string[] { "+", "-", "*", "/", "^" };
                string[] Numbers = UsingStr.Split(Signs, StringSplitOptions.None);
                if (Numbers.Length < 2)
                {
                    try
                    {
                        return View("Calculator3", Answer);
                    }
                    catch
                    {
                        return RedirectToAction(nameof(Calculator3));
                    }
                }
                else
                {
                    string SingsStr = UsingStr.Replace(Numbers[0], string.Empty);
                    SingsStr = SingsStr.Replace(Numbers[1], string.Empty);
                    long A = _NS.From11To10(Numbers[0], 11);
                    long B = _NS.From11To10(Numbers[1], 11);
                    if (SingsStr == "+")
                    {
                        Answer = Convert.ToInt64(_NS.Addition(Convert.ToString(A), Convert.ToString(B)));
                    }
                    if (SingsStr == "-")
                    {
                        Answer = Convert.ToInt64(_NS.Substraction(Convert.ToString(A), Convert.ToString(B)));
                    }
                    if (SingsStr == "*")
                    {
                        Answer = Convert.ToInt64(_NS.Multiplication(Convert.ToString(A), Convert.ToString(B)));
                    }
                    if (SingsStr == "/")
                    {
                        Answer = Convert.ToInt64(_NS.Division(Convert.ToString(A), Convert.ToString(B)));
                    }
                    if (SingsStr == "^")
                    {
                        Answer = Convert.ToInt64(_NS.Power(Convert.ToString(A), Convert.ToString(B)));
                    }
                    try
                    {
                        return View("Calculator3", _NS.From10To11(Answer, 11));
                    }
                    catch
                    {
                        return RedirectToAction(nameof(Calculator3));
                    }
                }
            }
            catch { return RedirectToAction(nameof(Calculator3)); }
        }
    
        public ViewResult Calculator3()
        {
            return View();
        }
    }
}