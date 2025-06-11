using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public double HasWheels { get; set; } = 4;
    public double HasDoors { get; set; } = 4;
    public string Model { get; set; } = "Toyota";
    public double Engine { get; set; } = 8;
    public string CompanyName { get; set; } = "Toyota";
    public string Motto { get; set; } = "Let's go places.";
    public bool HasChangedGears { get; set; }
    
    public bool HasFourWheelDrive { get; set; } = true;

    public void Drive()
    {
        if (HasFourWheelDrive == true)
        {
            Console.WriteLine($"Four wheel drive{GetType().Name} now driving foward. . .");
        }
        else
        {
            Console.WriteLine($"Four wheel drive{GetType().Name} now driving back. . .");
        }
    }

    public void Reverse()
    {
        if (HasChangedGears == true)
        {
            Console.WriteLine($"{GetType().Name} now reverse . .");
            HasChangedGears = false;
        }
        else
        {
            Console.WriteLine("Can't reverse until we change gears.");
        }
    }

    public void Park()
    {
        if (HasChangedGears == true)
        {
            Console.WriteLine($"{GetType().Name} now in park. . .");
        }
        else
        {
            Console.WriteLine("Can't park until we change gears.");
        }
    }

    public void ChangeGears(bool isChanged)
    {
        HasChangedGears = isChanged;
    }
}