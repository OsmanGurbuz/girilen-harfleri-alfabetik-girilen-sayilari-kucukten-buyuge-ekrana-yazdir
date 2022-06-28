using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string a ;
            object rakamlar;
            
            
            var list = new List<string>();
            
            Console.WriteLine("Alfabetik sırslanması için önce harfleri giriniz-iki defa aynı harf girilemez-");
            a = Console.ReadLine();
            list.Add(a);
            Console.WriteLine("Rakamları giriniz");
            rakamlar = Console.ReadLine();
            Console.WriteLine("----------------------------");
            int uzunluk = a.Length;
            list.Sort();
            
            Console.Write("Alfabetik sıralı hali :");
            
            
            Console.WriteLine(list);
            Console.WriteLine(rakamlar);
            Console.ReadLine();



        }
    }
}
