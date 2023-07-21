using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	public interface IBoatFactory
	{
		//This is the factory interface
		int GetBoatLength { get; }
		List<(int, int)> GetOrientation { get; }
		void Position(int x, int y);
		void SetOrientation();
		
	}
}
