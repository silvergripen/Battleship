using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	internal interface IStrategy
	{
		//This is the strategy interface
		Placement placement { get; }
		public void FiringSetup(int fire);
	}
}
