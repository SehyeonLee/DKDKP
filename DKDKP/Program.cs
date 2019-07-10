using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKDKP
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("-Ling Ling. Ling Ling");
			System.Threading.Thread.Sleep(3000);
			Console.WriteLine("A morning call wakes me. Sunshine is come to me through window.");
			System.Threading.Thread.Sleep(1000);
			Console.WriteLine("I Turn off the morning call and get up.");
			System.Threading.Thread.Sleep(1000);
			Console.WriteLine("I'd steel sleepy, but soon my mind get clear.");
			System.Threading.Thread.Sleep(1000);
			Console.WriteLine("A calendar says me \"Today is Sunday!\" Hmm... What will i do today?");
			System.Threading.Thread.Sleep(1000);
			Console.WriteLine("1.Go to Library 2.Go to university 3.stay home 4.go to internet cafe");
			int imsi = Int32.Parse(Console.ReadLine());
			switch(imsi)
			{
				case 1:
					Console.WriteLine("Library is quiet place.");
					System.Threading.Thread.Sleep(1000);
					Console.WriteLine("And my friend");
					break;
			}
		}
	}
}
