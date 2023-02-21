using System;

public class Ships
{
    public string ShipName { get; set; }
    public int Length { get; set; }
    public int Hits { get; set; }
    public bool isShipSunk
    {
        get
        {
            return Length <= Hits;
        }
    }


}
public class AircraftCarrier : Ships
{
    public AircraftCarrier()
        {
            ShipName = "Aircraft Carrier";
            Length = 5;
        }
}

public class Destroyer : Ships
{
    public Destroyer() 
    {
        ShipName = "Destroyer";
        Length = 4;
    }
}

public class WarShip : Ships
{
    public WarShip()
    {
        ShipName = "Warship";
        Length = 3;
    }
}

public class Submarine : Ships
{
    public Submarine()
    {
        ShipName = "Submarine";
        Length = 2;
    }
}