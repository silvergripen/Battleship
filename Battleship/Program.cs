namespace Battleship
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//
			//BoatFactory is a factory pattern. This includes IBoatFactory, CruiserRight, CruiserLeft and BoatFactory, Used to build different types of boat and their orientation.
			//Firing is a strategy Pattern. This includes IStrategy, FiringX and FiringY used to fire on position x or position y
            //Placement is a singleton. It runs only once to place the boats. 
			//
			 Placement placement = Placement.Instance;
            bool boat1Sunk = false;
            bool boat2Sunk = false;
            int checkSum = 0;
            // Create board
            Board board = new Board();
            FiringX firingX = new FiringX(placement);
            FiringY firingY = new FiringY(placement);

            // Print board
            while (true)
            {
                board.PrintBoard();

				if (checkSum >= placement.sum)
				{
					Console.WriteLine("You Win");
					break;
				}
				Console.WriteLine("Write the x coordinate");
                int x;
                if (Int32.TryParse(Console.ReadLine(), out x))
                {
                    firingX.FiringSetup(x);
                }
                Console.WriteLine("Write the y coordinate");
                int y;
                if (Int32.TryParse(Console.ReadLine(), out y))
                {
                    firingY.FiringSetup(y);
                }

                // Update the board with the hits and misses
                if (firingX.Boat1XHit && firingY.Boat1YHit && !boat1Sunk)
                {
                    Console.WriteLine("You hit a boat");
                    checkSum++;
                    board.UpdateBoard(x, y, 'H'); // Mark the hit on the board
                }
                else if (firingX.Boat2XHit && firingY.Boat2YHit && !boat2Sunk)
                {
                    Console.WriteLine("You hit a boat");
                    checkSum++;
                    board.UpdateBoard(x, y, 'H'); // Mark the hit on the board
                }
                else
                {
                    Console.WriteLine("You Missed");
                    board.UpdateBoard(x, y, 'M'); // Mark the miss on the board
                }
            }
		}
	}
}