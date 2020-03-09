using System;

namespace InheritanceIntro
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine("SILENCE!!!!!");
        }

        //override the default behavior of the toString object method.
        public override string ToString()
        {
            return "This is my Tesla";
        }
    }

}