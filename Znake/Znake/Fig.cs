using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znake
{
	class Fig
	{
		protected List<Point> pList;

		public void Draw()
		{
			foreach (Point p in pList)
			{
				p.Draw();
			}
		}
	}
}
