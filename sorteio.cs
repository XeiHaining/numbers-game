using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

	public static class Program
	{
		public static void Main()
		{
			int n;
			Random r = new Random();
			int res = r.Next(1, 6);
			Console.WriteLine("Numbers game\n");
			Console.Write("Enter a number from 1 to 6: ");
			n = Int32.Parse(Console.ReadLine());
			if (n == res)
			{
				Console.WriteLine("\nYou win!!");
			}
			else if (n != res)
			{
				Console.WriteLine("\nYou lost\nThe number drawn was: " + res);
			}
		}
	}
}