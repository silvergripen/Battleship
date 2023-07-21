using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
	//This board will run after every choice and re render the board. Factory? maybe
	internal class Board
	{
		int xSize = 7;
		int ySize = 5;
		private char[,] boardCoordinates;

        public Board()
        {
			boardCoordinates = new char[xSize, ySize];

			InitializeBoard();
		}

		public void UpdateBoard(int x, int y, char symbol)
		{
			boardCoordinates[x, y] = symbol; // Set the value at the specified position
		}
		private void InitializeBoard()
		{
			for (int y = 0; y < ySize; y++)
			{
				for (int x = 0; x < xSize; x++)
				{
					boardCoordinates[x, y] = '~';
				}
			}
		}
		public void PrintBoard()
		{
			for (int y = 0; y < ySize; y++)
			{
				for (int x = 0; x < xSize; x++)
				{
					Console.Write(boardCoordinates[x, y]);
				}
				Console.WriteLine();
			}
		}

	}
}
