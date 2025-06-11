using System.Dynamic;

namespace InterfaceExercise;

public interface IVehicle
{
    public double HasWheels { get; set; }
    public double HasDoors { get; set; }
    public string Model { get; set; }
    public double Engine { get; set; }
    
    public void Drive();
    public void Reverse();
    public void Park();
    public void ChangeGears(bool isChanged);

}  