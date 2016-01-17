using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znake
{
	class Snake : Fig
	{
		Direx direction;

		public Snake(Point tail, int length, Direx _direction)
		{
			direction = _direction;
			pList = new List<Point>();
			for(int i=0; i<length; i++)
			{
				Point p = new Point(tail);
				p.Move(i, direction);
				pList.Add(p);
			}
		}

		internal void Move()
		{
			Point tail = pList.First();
			pList.Remove(tail);
			Point head = GetNextPoint();
			pList.Add(head);

			tail.Clear();
			head.Draw();
		}

		public Point GetNextPoint()
		{
			Point head = pList.Last();
			Point nextpoint = new Point(head);
			nextpoint.Move(1, direction);
			return nextpoint;
		}

		public void HandleKey(ConsoleKey key)
		{
			if (key == ConsoleKey.LeftArrow)
				direction = Direx.LEFT;
			else if (key == ConsoleKey.RightArrow)
				direction = Direx.RIGHT;
			else if (key == ConsoleKey.DownArrow)
				direction = Direx.DOWN;
			else if (key == ConsoleKey.UpArrow)
				direction = Direx.UP;
		}
	}
}
