using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Felix Wankel'in Öz Geçmişi :");
            Dictionary<int, string> dictonary = new Dictionary<int, string>();
            dictonary.Add(1902, "13 Ağustos: Felix Wankel'in Doğumu Yılı");
            dictonary.Add(1954, "Döner Pistonlu Motor ( Rotary-Wankel motoru) Felix Wankel tarafından geliştirilmiştir.");
            dictonary.Add(1988, "9 Ekim: Felix Wankel'in Ölüm Yılı");

            foreach (var item in dictonary)
            {
                Console.WriteLine(item);
            }
        }
    }
}
