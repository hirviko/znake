using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znake
{
	class VL : Fig
	{
		public VL(int x, int yT, int yB, char sym)
		{
			pList = new List<Point>();
			for (int y = yT; y <= yB; y++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}
	}
}
