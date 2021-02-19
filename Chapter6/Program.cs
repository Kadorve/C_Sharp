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

            int first = Math.Max(Math.Max(thousands, hundreds), Math.Max(dozens, units));
            int fourth = Math.Min(Math.Min(thousands, hundreds), Math.Min(dozens, units));
            int second = Math.Min(Math.Max(thousands, hundreds), Math.Max(dozens, units));
            int third = Math.Max(Math.Min(thousands, hundreds), Math.Min(dozens, units));
            int n2 = Math.Max(second, third);
            int n3 = Math.Min(second, third);
            
            Console.WriteLine(first + "" + n2 + "" + n3 + "" + fourth);
        }
    }
}
