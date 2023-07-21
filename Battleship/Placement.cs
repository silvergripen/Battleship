using Battleship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Det här är en singleton
internal class Placement
{
	public int sum;
	private static List<(int, int)> boat1Coordinates;
	private static List<(int, int)> boat2Coordinates;
	public List<int> Boat1XCoordinates { get; private set; }
	public List<int> Boat1YCoordinates { get; private set; }
	public List<int> Boat2XCoordinates { get; private set; }
	public List<int> Boat2YCoordinates { get; private set; }
	public List<(int, int)> Boat1Coordinates { get { return boat1Coordinates; } }
	public List<(int, int)> Boat2Coordinates { get { return boat2Coordinates; } }

	private Placement()
    {
        BoatFactory boatFactory = new BoatFactory();
        IBoatFactory boat1 = boatFactory.CreateBoat("CruiserU", 4, 4);
		boat1Coordinates = boat1.GetOrientation;
		IBoatFactory boat2 = boatFactory.CreateBoat("CruiserR", 1, 1);
		boat2Coordinates = boat2.GetOrientation;

		Boat1XCoordinates = new List<int>();
		Boat1YCoordinates = new List<int>();
		Boat2XCoordinates = new List<int>();
		Boat2YCoordinates = new List<int>();

		foreach (var (x, y) in boat1Coordinates)
		{
			Boat1XCoordinates.Add(x);
			Boat1YCoordinates.Add(y);
		}

		foreach (var (x, y) in boat2Coordinates)
		{
			Boat2XCoordinates.Add(x);
			Boat2YCoordinates.Add(y);
		}
		this.sum = boat1.GetBoatLength + boat2.GetBoatLength;
	}

    private static readonly Lazy<Placement> instance = new Lazy<Placement>(() => new Placement());

    public static Placement Instance => instance.Value;
}
