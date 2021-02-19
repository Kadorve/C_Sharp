using System;

namespace Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = Convert.ToInt32(Console.ReadLine());
            int thousands = digit / 1000 % 10;
            int hundreds = digit / 100 % 10;
            int dozens = digit / 10 % 10;
            int units = digit % 10;
            Console.WriteLine("Базовые числа: thousands = " + thousands + " ,hundreds = " + hundreds + " ,dozens = " + dozens + ", units = " + units);

            byte max1 = (byte)Math.Max(thousands, hundreds);
            byte min1 = (byte)Math.Min(thousands, hundreds);
            byte max2 = (byte) Math.Max(dozens, units);
            byte min2 = (byte) Math.Min(dozens, units);
            byte max3 = Math.Max(max1, max2);
            byte min3 = Math.Min(max1, max2);
            byte max4 = Math.Max(min1, min2);
            byte min4 = Math.Min(min1, min2);
            
            Console.WriteLine(max3 + "" + min3 + "" + max4 + "" + min4);
        }
    }
}
