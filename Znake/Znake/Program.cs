using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Znake
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetBufferSize(80, 25);

			HL line1 = new HL(0,78,0,'*');
			line1.Draw();

			HL line2 = new HL(0,78,24,'*');
			line2.Draw();

			VL line3 = new VL(0,0,24,'*');
			line3.Draw();

			VL line4 = new VL(78,0,24,'*');
			line4.Draw();

			Point p = new Point(7,5,'*');
			Snake snake = new Snake(p, 5, Direx.RIGHT);
			snake.Draw();

			while (true)
			{
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
				Thread.Sleep(150);
				snake.Move();
			}

			//Console.ReadLine();
		}
	}
}
