using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	public class BoatFactory
	{
		//This is the factory builder
		public IBoatFactory CreateBoat(String types, int x, int y)
		{
			IBoatFactory boat = null;

			switch (types)
			{
				case "CruiserU":
					boat = new CrusierUp();

					break;
				case "CruiserR":
					boat = new CruiserRight();
					break;
				default:
					throw new ArgumentException("No boat type");
			}
			boat.Position(x, y);
			boat.SetOrientation();
			return boat;
		}
	}
}
