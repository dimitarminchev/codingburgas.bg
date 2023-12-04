using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransport
{	public static class Console
	{
		public static void WriteLine(string s)
		{
			var colorBackup = System.Console.ForegroundColor;
			System.Console.ForegroundColor = System.ConsoleColor.Green;
			System.Console.WriteLine(s);
			System.Console.ForegroundColor = colorBackup;
		}
	}
}
