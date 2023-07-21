using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	public class CrusierUp : IBoatFactory
	{
		//This is part of a factory pattern
		public int xStart;
		public int yStart;
		int boatLength = 2;
		List<(int, int)> orientation = new List<(int, int)>();
		public List<(int, int)> GetOrientation { get { return orientation; } }
		public int GetBoatLength { get { return boatLength; } }

		public void Position(int xStart, int yStart)
		{
			this.xStart = xStart;
			this.yStart = yStart;
			orientation.Add((xStart, yStart));
		}

		public void SetOrientation()
		{
			for (int i = 0; i < boatLength; i++)
			{
				orientation.Add((xStart, yStart--));
			}
		}
	}
}