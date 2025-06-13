using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car
            {
                Model = "Rav 4",
                CompanyName = "Toyota",
                Motto = "Lets go places",
                Engine = 6.5
            };
            
            Console.WriteLine($"Car: {myCar.Model}, Company: {myCar.CompanyName}, Motto: {myCar.Motto}, Engine: {myCar.Engine}");
            
            myCar.ChangeGears(true);
            myCar.Drive();
            myCar.ChangeGears(true);
            myCar.Park();


            var myTruck = new Truck();

            myTruck.Model = "Tacoma";
            myTruck.CompanyName = "Toyota";
            myTruck.Motto = "Lets go places";
            myTruck.HasFourWheelDrive = true;
            
            Console.WriteLine($"Truck: {myTruck.Model}, Company: {myTruck.CompanyName}, FourWheel: {myTruck.HasFourWheelDrive}");
            
            myTruck.ChangeGears(true);
            myTruck.Drive();
            myTruck.Reverse();
            myTruck.ChangeGears(true);
            myTruck.Park();
            


            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
