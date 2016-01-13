using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znake
{
	class Point
	{
		public int x;
		public int y;
		public char sym;

		public Point(int _x, int _y, char _sym)
		{
			x = _x;
			y = _y;
			sym = _sym;
		}

		public Point(Point p)
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
		}

		public void Move(int offset, Direx direction)
		{
			if(direction == Direx.RIGHT) { x = x + offset; }
			else if(direction == Direx.LEFT) { x = x - offset; }
			else if(direction == Direx.UP) { y = y + offset; }
			else if (direction == Direx.DOWN) { y = y - offset; }
		}

		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}
	}
}
