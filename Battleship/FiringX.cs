using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{

	//Det här är en Strategy pattern
	internal class FiringX : IStrategy
	{
		public int xFire { get; set; }
		public static int amountOfHits { get; set; }
		public  bool Boat1XHit { get; set; }
		public  bool Boat2XHit { get; set; }
		public Placement placement { get; }

		
		public FiringX(Placement placement)
		{
			this.placement = placement;
		}
		
		public void FiringSetup(int xfire)
		{
			this.xFire = xfire;
			if (placement.Boat1XCoordinates.Contains(xFire))
			{
				Boat1XHit = true;
			}
			else if (placement.Boat2XCoordinates.Contains(xfire))
			{
				Boat2XHit = true;
			}
			else
			{
				Boat1XHit = false;
				Boat2XHit = false;
			}
		}
	}
}
