﻿using System;

namespace DatetimeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // Günün Tarihini Getirir.
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); //String olarak günü verir.
            Console.WriteLine(DateTime.Now.DayOfYear); // int olarak günü verir.

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString()); // 25/01/2022

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // 11:25

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); // 25
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); // 04
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // April

            Console.WriteLine(DateTime.Now.ToString("yy")); // 21
            Console.WriteLine(DateTime.Now.ToString("yyy")); // 2021

            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); // Mutlak değerini alır.
            Console.WriteLine(Math.Sin(10)); // sinüs değerini verir.
            Console.WriteLine(Math.Cos(10)); // cosinüs değerini verir.
            Console.WriteLine(Math.Tan(10)); // tanjant değerini verir.

            Console.WriteLine(Math.Ceiling(22.3)); // 23
            Console.WriteLine(Math.Round(22.3)); // 22
            Console.WriteLine(Math.Round(22.7)); // 23
            Console.WriteLine(Math.Floor(22.7)); // 22

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4)); // 3^4
            Console.WriteLine(Math.Sqrt(9)); // karekök
            Console.WriteLine(Math.Log(9)); // Logaritma işlemi -e tabanı-
            Console.WriteLine(Math.Exp(3)); // e^3
            Console.WriteLine(Math.Log10(10)); // 10 tabanında logaritma karşılığı
        }
    }
}
