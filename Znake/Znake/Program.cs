﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znake
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p1 = new Point(1,3,'*');
			p1.Draw();
			Point p2 = new Point(2, 3, '*');
			p2.Draw();

			Console.ReadLine();
		}
	}
}
