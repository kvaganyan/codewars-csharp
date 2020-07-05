using System;

namespace SimpleFractionMixedNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Kata
    {
        public static string MixedFraction(string s)
        {
            int iDivNumer = int.Parse(s.Split('/')[0]);
            int iDivDenom = int.Parse(s.Split('/')[1]);

            if (iDivDenom == 0) throw new DivideByZeroException();
            if (iDivNumer == 0) return "0";

            int gcd = eucGCD(Math.Abs(iDivNumer), Math.Abs(iDivDenom));

            iDivNumer = gcd != 0 ? iDivNumer / gcd : iDivNumer;
            iDivDenom = gcd != 0 ? iDivDenom / gcd : iDivDenom;

            int iReturnWhole = iDivNumer / iDivDenom != 0 ? iDivNumer / iDivDenom : 0;
            int iReturnRemainderNumer = iReturnWhole != 0 ? Math.Abs(iDivNumer % iDivDenom) : iDivNumer % iDivDenom;
            int iReturnRemainderDenom = iReturnWhole != 0 ? Math.Abs(iDivDenom) : iDivDenom;
            if (iReturnRemainderDenom < iReturnRemainderNumer)
            {
                iReturnRemainderNumer *= -1;
                iReturnRemainderDenom *= -1;
            }

            string sReturnWhole = iReturnWhole != 0 ? iReturnWhole.ToString() : string.Empty;
            string sReturnRemainer = iReturnRemainderNumer != 0 ? string.Format("{0}/{1}", iReturnRemainderNumer, iReturnRemainderDenom) : string.Empty;

            return string.Format("{0} {1}", sReturnWhole, sReturnRemainer).Trim();
        }

        public static int eucGCD(int a, int b)
        {
            while (b != 0)
            {
                int remain = b;
                b = a % b;
                a = remain;
            }

            return a;
        }
    }
}