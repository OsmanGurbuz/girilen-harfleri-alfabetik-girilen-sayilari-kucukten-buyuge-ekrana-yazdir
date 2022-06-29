using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

			List<Char> list = new List<Char>();

			Console.WriteLine("CTRL+C to exit");

			while (true)
			{
				Console.WriteLine("Bir Karakter giriniz: ");
				char c = Console.ReadKey().KeyChar;

				bool has = false;

				for (int i = 0; i < list.Count(); i++)
				{
					if (list[i] == c)
					{
						has = true;
					}
				}

				if (!has)
				{
					list.Add(c);
				}

				list = CustomShort(list.ToArray());

				Console.Write("\n---->");
				for (int i = 0; i < list.Count(); i++)
				{
					Console.Write(list[i]);
				}
				Console.Write("\n");
			}
		}

		static List<Char> CustomShort(Char[] inp)
		{
			List<char> intlist = new List<char>();
			List<char> charlist = new List<char>();

			for (int i = 0; i < inp.Count(); i++)
			{
				int ASCIIValue = (int)(inp[i]);
				if (ASCIIValue >= 48 && ASCIIValue <= 57)
				{
					intlist.Add(inp[i]);
				}
				else
				{
					charlist.Add(inp[i]);
				}
			}

			charlist.Sort();

			intlist.Sort();

			for (int i = 0; i < intlist.Count(); i++) 
			{
				charlist.Add(intlist[i]);
			}

			return charlist;
		}
	}
    
}
