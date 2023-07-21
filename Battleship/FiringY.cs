using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	//Det här är en Strategy pattern
	internal class FiringY: IStrategy
	{
		public int yFire { get; set; }

		public static int amountOfHits { get; set; }

		public bool Boat1YHit { get; set; }
		public bool Boat2YHit { get; set; }

		public Placement placement { get; }

		public FiringY(Placement placement)
		{
			this.placement = placement;
		}

		public void FiringSetup(int yFire)
		{
			this.yFire = yFire;
			if (placement.Boat1YCoordinates.Contains(yFire))
			{
				Boat1YHit = true;
			}
			else if (placement.Boat2YCoordinates.Contains(yFire))
			{
				Boat2YHit = true;
			}
			else
			{
				Boat1YHit = false;
				Boat2YHit = false;
			}
		}
	}
}
